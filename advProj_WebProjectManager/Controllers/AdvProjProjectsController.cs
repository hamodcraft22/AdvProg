using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using advProj_WebProjectManager.Models;
using advProj_WebProjectManager.ViewModels;
using advProj_BusinessObjects.GlobalClass;

namespace advProj_WebProjectManager.Controllers
{
    [Authorize]
    public class AdvProjProjectsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;
        private readonly UserManager<AdvProg_ApplicationUser> _userManager;

        public AdvProjProjectsController(AdvProg_DatabaseContext context, UserManager<AdvProg_ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [Authorize]
        [HttpGet]
        // index action with search function (on get)
        public async Task<IActionResult> Index(string? ProjectName, string? StatusInput, string? Member)
        {


            try
            {
                var advProg_DatabaseContext = _context.AdvProjProjects.Include(a => a.Manager).Include(a => a.Status).Include(a => a.AdvProjTasks).AsQueryable();

                // check if the user is accsesing his 
                if (Member != null)
                {
                    // filter the projects where the user is a part of (has project task in this project)
                    // seprated for ease of readability 
                    var userTaksIds = _context.AdvProjUserTasks.Where(a => a.UserId == Global.userID).Select(b => b.TaskId);
                    var projectTasksIds = _context.AdvProjTasks.Where(a => userTaksIds.Contains(a.TaskId)).Select(b => b.ProjectId);
                    advProg_DatabaseContext = advProg_DatabaseContext.Where(a => projectTasksIds.Contains(a.ProjectId));

                    //FIX
                }
                else
                {
                    // show "my projects" - projects where i manage
                    advProg_DatabaseContext = advProg_DatabaseContext.Where(f => f.ManagerId == Global.userID);
                }


                // filttering based on seach input (project name)
                if (!String.IsNullOrEmpty(ProjectName))
                {
                    advProg_DatabaseContext = advProg_DatabaseContext.Where(f => f.ProjectName.Contains(ProjectName));
                }

                // filter based on status selection
                if (!String.IsNullOrEmpty(StatusInput))
                {
                    advProg_DatabaseContext = advProg_DatabaseContext.Where(f => f.StatusId == Convert.ToInt32(StatusInput));
                }

                // view model using the search parameters 
                var projectViewModel = new ProjectIndexViewModel
                {
                    Projects = await advProg_DatabaseContext.ToListAsync(),
                    Status = _context.AdvProjPStatuses
                };

                return View(projectViewModel);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }


        [Authorize]
        // GET: AdvProjProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            try
            {
                if (id == null || _context.AdvProjProjects == null)
                {
                    return NotFound();
                }

                // to check if the user is the manager or a member of this project
                var listOfManagerProjects = _context.AdvProjProjects.Where(a => a.ManagerId == Global.userID).Select(f => f.ProjectId).ToArray();

                // to retrive if the user is a member of this project
                var userTaksIds = _context.AdvProjUserTasks.Where(a => a.UserId == Global.userID).Select(b => b.TaskId);
                var projectTasksIds = _context.AdvProjTasks.Where(a => userTaksIds.Contains(a.TaskId)).Select(b => b.ProjectId);
                var listOfMemberProjects = _context.AdvProjProjects.Where(a => projectTasksIds.Contains(a.ProjectId)).Select(f => f.ProjectId).ToArray();


                if (!(Array.Exists(listOfMemberProjects, element => element == id)))
                {
                    if (!(Array.Exists(listOfManagerProjects, element => element == id)))
                    {
                        TempData["ErrorMsg"] = "You dont have accses to the selected Project";
                        return RedirectToAction("Index");
                    }
                }


                var advProjProject = await _context.AdvProjProjects
                    .Include(a => a.Manager)
                    .Include(a => a.Status)
                    .FirstOrDefaultAsync(m => m.ProjectId == id);
                if (advProjProject == null)
                {
                    return NotFound();
                }

                return View(advProjProject);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        [Authorize]
        // GET: AdvProjProjects/Create
        // no validation required as create only creates a new project not related to anything and every user can create one
        public IActionResult Create()
        {


            try
            {
                ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "FullName");
                ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName");
                return View();
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        // POST: AdvProjProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,ProjectName,ProjectDescription,StartDate,EndDate,FinishDate,StatusId")] AdvProjProject advProjProject)
        {



            try
            {
                // add defualt values to user (manager id) and creation time
                AdvProjProject newProject = advProjProject;
                newProject.CreateDate = DateTime.Now.Date;
                newProject.ManagerId = Global.userID;
                newProject.StatusId = 1;

                if (ModelState.IsValid)
                {
                    _context.Add(newProject);
                    await _context.SaveChangesAsync();

                    // audit - adding a new audit to the list 
                    LogsAudits.addAudit("Web", "Create", "Project", null, newProject.ToString(), newProject.ProjectId, (int)Global.userID);


                    return RedirectToAction(nameof(Index));
                }
                ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", newProject.ManagerId);
                ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName", newProject.StatusId);
                return View(newProject);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        [Authorize]
        // GET: AdvProjProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {



            try
            {
                if (id == null || _context.AdvProjProjects == null)
                {
                    return NotFound();
                }

                // to check if the user is the manager of this project
                var listOfUserIds = _context.AdvProjProjects.Where(a => a.ManagerId == Global.userID).Select(f => f.ProjectId).ToArray();
                if (!Array.Exists(listOfUserIds, element => element == id))
                {
                    TempData["ErrorMsg"] = "You dont have accses to the selected Project";
                    return RedirectToAction(nameof(Index));
                }

                var advProjProject = await _context.AdvProjProjects.FindAsync(id);
                if (advProjProject == null)
                {
                    return NotFound();
                }
                ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjProject.ManagerId);
                ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName", advProjProject.StatusId);
                return View(advProjProject);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        [Authorize]
        // POST: AdvProjProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,ProjectName,ProjectDescription,CreateDate,StartDate,EndDate,FinishDate,StatusId,ManagerId")] AdvProjProject advProjProject)
        {



            try
            {
                if (id != advProjProject.ProjectId)
                {
                    return NotFound();
                }

                // to check if the user is the manager of this project
                var listOfUserIds = _context.AdvProjProjects.Where(a => a.ManagerId == Global.userID).Select(f => f.ProjectId).ToArray();
                if (!Array.Exists(listOfUserIds, element => element == id))
                {
                    TempData["ErrorMsg"] = "You dont have accses to the selected Project";
                    return RedirectToAction(nameof(Index));
                }



                AdvProjProject updateProject = advProjProject;
                updateProject.ManagerId = Global.userID;

                if (updateProject.StatusId == 5)
                {
                    updateProject.FinishDate = DateTime.Now.Date;
                }


                // new dbcontext object to avoide tracking issues 
                AdvProg_DatabaseContext secondContext = new AdvProg_DatabaseContext();

                var oldProject = secondContext.AdvProjProjects.Find(advProjProject.ProjectId);
                var oldValue = oldProject.ToString();

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(updateProject);
                        await _context.SaveChangesAsync();

                        // audit - adding a new audit to the list 
                        LogsAudits.addAudit("Web", "Update", "Projects", oldValue, updateProject.ToString(), advProjProject.ProjectId,(int)Global.userID);

                        await _context.SaveChangesAsync();

                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!AdvProjProjectExists(updateProject.ProjectId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", updateProject.ManagerId);
                ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName", updateProject.StatusId);
                return View(updateProject);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID); ;

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        [Authorize]
        // GET: AdvProjProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {



            try
            {
                if (id == null || _context.AdvProjProjects == null)
                {
                    return NotFound();
                }

                // to check if the user is the manager of this project
                var listOfUserIds = _context.AdvProjProjects.Where(a => a.ManagerId == Global.userID).Select(f => f.ProjectId).ToArray();
                if (!Array.Exists(listOfUserIds, element => element == id))
                {
                    TempData["ErrorMsg"] = "You dont have accses to the selected Project";
                    return RedirectToAction(nameof(Index));
                }

                var advProjProject = await _context.AdvProjProjects
                    .Include(a => a.Manager)
                    .Include(a => a.Status)
                    .FirstOrDefaultAsync(m => m.ProjectId == id);


                if (advProjProject == null)
                {
                    return NotFound();
                }

                return View(advProjProject);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        [Authorize]
        // POST: AdvProjProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {


            try
            {
                if (_context.AdvProjProjects == null)
                {
                    return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjProjects'  is null.");
                }
                var advProjProject = await _context.AdvProjProjects.FindAsync(id);
                if (advProjProject != null)
                {
                    _context.AdvProjProjects.Remove(advProjProject);
                }

                await _context.SaveChangesAsync();

                // audit - adding a new audit to the list 
                LogsAudits.addAudit("Web", "Delete", "Projects", advProjProject.ToString(),null, advProjProject.ProjectId,(int)Global.userID);

                
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        private bool AdvProjProjectExists(int id)
        {
            return (_context.AdvProjProjects?.Any(e => e.ProjectId == id)).GetValueOrDefault();
        }
    }
}
