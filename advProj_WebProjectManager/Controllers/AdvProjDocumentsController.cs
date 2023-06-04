using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using System.Drawing;
using advProj_WebProjectManager.Models;
using Microsoft.AspNetCore.Authorization;
using advProj_BusinessObjects.GlobalClass;

namespace advProj_WebProjectManager.Controllers
{
    [Authorize]
    public class AdvProjDocumentsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjDocumentsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjDocuments
        public async Task<IActionResult> Index(int? tid)
        {


            try
            {
                var advProg_DatabaseContext = _context.AdvProjDocuments.Include(a => a.Task).Include(a => a.User).Where(f => f.TaskId == tid);
                return View(await advProg_DatabaseContext.ToListAsync());
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

        // GET: AdvProjDocuments/Create
        public IActionResult Create()
        {


            try
            {
                // just returns view
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

        // POST: AdvProjDocuments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DocumentId,DocumentName,DocumentType,DocumentExt,DocumentPath,DocumentDescription,UploadDate,TaskId,UserId")] AdvProjDocument advProjDocument, List<IFormFile> files)
        {


            try
            {
                AdvProjDocument ActadvProjDocument = advProjDocument;

                int actTid = Convert.ToInt32(TempData["tid"]);

                ActadvProjDocument.UploadDate = DateTime.Now;
                ActadvProjDocument.UserId = Global.userID;
                ActadvProjDocument.TaskId = actTid;
                ActadvProjDocument.DocumentPath = "PlaceHolder";


                // skiping normal validation as it dosent work with files 
                // using required validation in form in html side
                if (true)
                {
                    long size = files.Sum(f => f.Length);

                    var filePaths = new List<string>();
                    foreach (var formFile in files)
                    {
                        if (formFile.Length > 0)
                        {
                            // full path to file in temp location
                            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadedFiles", formFile.FileName);
                            var dbfilePath = Path.Combine("UploadedFiles", formFile.FileName);
                            filePaths.Add(filePath);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                            ActadvProjDocument.DocumentPath = dbfilePath.ToString();
                        }
                    }
                    // process uploaded files


                    _context.Add(advProjDocument);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", new { tid = actTid });
                }

                ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjDocument.TaskId);
                ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjDocument.UserId);
                return View(advProjDocument);
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

        // GET: AdvProjDocuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {



            try
            {
                if (id == null || _context.AdvProjDocuments == null)
                {
                    return NotFound();
                }

                var advProjDocument = await _context.AdvProjDocuments
                    .Include(a => a.Task)
                    .Include(a => a.User)
                    .FirstOrDefaultAsync(m => m.DocumentId == id);
                if (advProjDocument == null)
                {
                    return NotFound();
                }

                return View(advProjDocument);
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

        // POST: AdvProjDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, int? tid)
        {


            try
            {
                if (_context.AdvProjDocuments == null)
                {
                    return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjDocuments'  is null.");
                }
                var advProjDocument = await _context.AdvProjDocuments.FindAsync(id);
                if (advProjDocument != null)
                {
                    _context.AdvProjDocuments.Remove(advProjDocument);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { tid = tid });
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

        private bool AdvProjDocumentExists(int id)
        {
            return (_context.AdvProjDocuments?.Any(e => e.DocumentId == id)).GetValueOrDefault();
        }
    }
}
