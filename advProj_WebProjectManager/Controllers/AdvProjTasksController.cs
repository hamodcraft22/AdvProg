using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using advProj_WebProjectManager.Models;
using advProj_WebProjectManager.ViewModels;
using Microsoft.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace advProj_WebProjectManager.Controllers
{
    public class AdvProjTasksController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjTasksController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // to enfore validation the id was chnaged to being the ProjectID, other ids were givin

        // GET: AdvProjTasks
        public async Task<IActionResult> Index(int? id, string? Member, string? TaskName, string? StatusInput)
        {
            // error and redirect if no task id was passed
            if (id == null)
            {
                TempData["ErrorMsg"] = "Task ID was not Provided, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            else
            {
                // craeting variables which are going to retrive the data
                var advProg_ProjectContext = _context.AdvProjProjects.Include(a => a.Manager).Include(a => a.Status).Include(a => a.AdvProjTasks).AsQueryable();
                var advProg_TasksContext = _context.AdvProjTasks.AsQueryable();

                // check if the user is able to access the givin project
                if (checkIfCanAcsProj((int)id))
                {
                    if (Member != null)
                    {
                        // get the user's tasks 
                        var userTaksIds = _context.AdvProjUserTasks.Where(a => a.UserId == Global.userID).Select(b => b.TaskId);

                        // filter ony the tasks which the user is a part of - Many to Many stuff
                        advProg_ProjectContext = advProg_ProjectContext.Where(a => a.ProjectId == id);
                        advProg_TasksContext = advProg_TasksContext.Where(a => a.ProjectId == id && userTaksIds.Contains(a.TaskId));
                    }
                    else
                    {
                        // check if the user is a manager, if so not allowed (without the memebr get request)
                        if (!checkIfCanMngProj((int)id))
                        {
                            TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                            return RedirectToAction("Index", "AdvProjProjects", new { area = "" });
                        }

                        // returning manager set of tasks - all tasks
                        advProg_ProjectContext = advProg_ProjectContext.Where(a => a.ProjectId == id);
                        advProg_TasksContext = advProg_TasksContext.Where(a => a.ProjectId == id);
                    }


                    // filttering based on seach input (Task name)
                    if (!String.IsNullOrEmpty(TaskName))
                    {
                        advProg_TasksContext = advProg_TasksContext.Where(f => f.TaskName.Contains(TaskName));
                    }

                    // filter based on status selection
                    if (!String.IsNullOrEmpty(StatusInput))
                    {
                        advProg_TasksContext = advProg_TasksContext.Where(f => f.StatusId == Convert.ToInt32(StatusInput));
                    }

                    // building the view model
                    var TasksModelView = new ProjectTasksViewModel
                    {
                        Project = await advProg_ProjectContext.Where(a => a.ProjectId == id).FirstOrDefaultAsync(),
                        projTasks = await advProg_TasksContext.Where(a => a.ProjectId == id).ToListAsync(),
                        Status = _context.AdvProjPStatuses
                    };

                    return View(TasksModelView);
                }
                else
                {
                    TempData["ErrorMsg"] = "You dont have access to the selecetd Project";
                    return RedirectToAction("Index", "AdvProjProjects", new { area = "" });
                }
            }
        }

        // GET: AdvProjTasks/Details/5
        public async Task<IActionResult> Details(int? id, int? tid, string? Member)
        {
            if (id == null || _context.AdvProjTasks == null || tid == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // custome method to check if tasks exist + member validation to return user to member page
            if (!AdvProjTaskExists((int)tid))
            {
                TempData["ErrorMsg"] = "Task does not exist, Please try again";
                if (Member != null)
                {
                    return RedirectToAction("Index", new { id = id, member = "true" });
                }
                else
                {
                    return RedirectToAction("Index", new { id = id });
                }
            }

            var advProjTask = await _context.AdvProjTasks
                .Include(a => a.Project)
                .Include(a => a.Status)
                .FirstOrDefaultAsync(m => m.TaskId == tid);


            return View(advProjTask);
        }

        // GET: AdvProjTasks/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if user cann add stuff for this project (manage it)
            if (!checkIfCanMngProj((int)id))
            {
                TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            ViewData["Users"] = new SelectList(_context.AdvProjUsers, "UserId", "FullName");

            // creating view model for the craete page
            var CreateViewModel = new NewTaskModelView
            {
                projectTask = new(),
                Users = _context.AdvProjUsers
            };

            return View(CreateViewModel);
        }

        // POST: AdvProjTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int? id, NewTaskModelView? newTask)
        {
            if (id == null || _context.AdvProjTasks == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if user cann add stuff for this project (manage it)
            if (!checkIfCanMngProj((int)id))
            {
                TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // add defualt values to user (manager id) and creation time
            AdvProjTask ActnewTask = newTask.projectTask;
            ActnewTask.CreateDate = DateTime.Now.Date;
            ActnewTask.ProjectId = id;
            ActnewTask.StatusId = 1;


            if (ModelState.IsValid)
            {
                _context.Add(ActnewTask);
                await _context.SaveChangesAsync();

                //creating user tasks objects
                foreach (string userItemID in newTask.selectIdArray)
                {
                    AdvProjUserTask newUserTask = new AdvProjUserTask();
                    newUserTask.TaskId = ActnewTask.TaskId;
                    newUserTask.UserId = Convert.ToInt32(userItemID);

                    _context.Add(newUserTask);
                }

                await _context.SaveChangesAsync();

                return RedirectToAction("Index", new { id = id });
            }

            // creating view model with existing objects - if there is an error 
            var CreateViewModel = new NewTaskModelView
            {
                projectTask = ActnewTask,
                Users = _context.AdvProjUsers
            };

            return View(CreateViewModel);
        }

        // GET: AdvProjTasks/Edit/5
        public async Task<IActionResult> Edit(int? id, int? tid)
        {
            if (id == null || _context.AdvProjTasks == null || tid == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if user cann add stuff for this project (manage it)
            if (!checkIfCanAcsProj((int)id))
            {
                TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if the task is avalible 
            if (!AdvProjTaskExists((int)tid))
            {
                TempData["ErrorMsg"] = "The Task is not availiable";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            var advProjTask = await _context.AdvProjTasks.FindAsync(tid);
            if (advProjTask == null)
            {
                return NotFound();
            }

            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName", advProjTask.StatusId);
            return View(advProjTask);
        }

        // POST: AdvProjTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int? tid, string? Member, [Bind("TaskId,TaskName,TaskDescription,CreateDate,StartDate,EndDate,FinishDate,StatusId,ProjectId")] AdvProjTask advProjTask)
        {
            if (tid != advProjTask.TaskId || tid == null || id == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if user cann add stuff for this project (manage it)
            if (!checkIfCanAcsProj((int)id))
            {
                TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if the task is avalible 
            if (!AdvProjTaskExists((int)tid))
            {
                TempData["ErrorMsg"] = "The Task is not availiable";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjTaskExists(advProjTask.TaskId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                // redirect to main page and go to member page if it was selected as a member //FIX add some succ alert
                if (Member != null)
                {
                    return RedirectToAction("Index", "AdvProjTasks", new { id = id, Member = "true" });
                }
                else
                {
                    return RedirectToAction("Index", "AdvProjTasks", new { id = id });
                }
            }

            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName", advProjTask.StatusId);
            return View(advProjTask);
        }

        // GET: AdvProjTasks/Delete/5
        public async Task<IActionResult> Delete(int? id, int? tid)
        {
            if (id == null || _context.AdvProjTasks == null || tid == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if user cann add stuff for this project (manage it)
            if (!checkIfCanMngProj((int)id))
            {
                TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if the task is avalible 
            if (!AdvProjTaskExists((int)tid))
            {
                TempData["ErrorMsg"] = "The Task is not availiable";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            var advProjTask = await _context.AdvProjTasks
                .Include(a => a.Project)
                .Include(a => a.Status)
                .FirstOrDefaultAsync(m => m.TaskId == tid);
            if (advProjTask == null)
            {
                return NotFound();
            }

            return View(advProjTask);
        }

        // POST: AdvProjTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id, int? tid)
        {
            if (id == null || tid == null)
            {
                return NotFound();
            }

            // custome way to check if the project id exists
            if (!AdvProjProjectExists((int)id))
            {
                TempData["ErrorMsg"] = "Project does not exist, Please try again";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if user cann add stuff for this project (manage it)
            if (!checkIfCanMngProj((int)id))
            {
                TempData["ErrorMsg"] = "You Cant Manage a task that's not Yours";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            // check if the task is avalible 
            if (!AdvProjTaskExists((int)tid))
            {
                TempData["ErrorMsg"] = "The Task is not availiable";
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            if (_context.AdvProjTasks == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjTasks'  is null.");
            }
            var advProjTask = await _context.AdvProjTasks.FindAsync(tid);
            if (advProjTask != null)
            {
                _context.AdvProjTasks.Remove(advProjTask);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AdvProjTasks", new { id = id });
        }

        private bool AdvProjTaskExists(int id)
        {
          return (_context.AdvProjTasks?.Any(e => e.TaskId == id)).GetValueOrDefault();
        }

        // custome methods to check if the user who is logged in can intreact with the tasks / projects
        private bool checkIfCanAcsProj(int projectID)
        {
            var listOfManagerProjects = _context.AdvProjProjects.Where(a => a.ManagerId == Global.userID).Select(f => f.ProjectId).ToArray();

            // to retrive if the user is a member of this project
            var userTaksIds = _context.AdvProjUserTasks.Where(a => a.UserId == Global.userID).Select(b => b.TaskId);
            var projectTasksIds = _context.AdvProjTasks.Where(a => userTaksIds.Contains(a.TaskId)).Select(b => b.ProjectId);
            var listOfMemberProjects = _context.AdvProjProjects.Where(a => projectTasksIds.Contains(a.ProjectId)).Select(f => f.ProjectId).ToArray();


            if (!(Array.Exists(listOfManagerProjects, element => element == projectID)))
            {
                if (!(Array.Exists(listOfMemberProjects, element => element == projectID)))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        private bool checkIfCanMngProj(int projectID)
        {
            var listOfManagerProjects = _context.AdvProjProjects.Where(a => a.ManagerId == Global.userID).Select(f => f.ProjectId).ToArray();

            if (!(Array.Exists(listOfManagerProjects, element => element == projectID)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // method to see if the project is present
        private bool AdvProjProjectExists(int id)
        {
            return (_context.AdvProjProjects?.Any(e => e.ProjectId == id)).GetValueOrDefault();
        }
    }
}
