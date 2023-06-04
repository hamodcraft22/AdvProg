using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using advProj_WebProjectManager.Models;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;

namespace advProj_WebProjectManager.Controllers
{
    [Authorize]
    public class AdvProjCommentsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjCommentsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjComments
        public async Task<IActionResult> Index(string? tid)
        {
            try
            {
                int taskID = Convert.ToInt32(tid);
                var advProg_DatabaseContext = _context.AdvProjComments.Include(a => a.Response).Include(a => a.Task).Include(a => a.User).Where(f => f.TaskId == taskID);
                return View(await advProg_DatabaseContext.ToListAsync());
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                AdvProjLog newLog = new AdvProjLog();
                newLog.LogSource = "Web"; 
                newLog.ExceptionMsg = ex.Message;
                newLog.Date = DateTime.Now;
                if (Global.userID != null)
                {
                    newLog.UserId = Global.userID;
                }

                // save exception
                _context.Add(newLog);
                _context.SaveChanges();

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        // GET: AdvProjComments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjComments == null)
            {
                return NotFound();
            }

            var advProjComment = await _context.AdvProjComments
                .Include(a => a.Response)
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (advProjComment == null)
            {
                return NotFound();
            }

            return View(advProjComment);
        }

        // GET: AdvProjComments/Create
        public IActionResult Create(string? tid)
        {
            ViewData["ResponseId"] = new SelectList(_context.AdvProjComResponses, "ResponseId", "ResponseName");
            return View();
        }

        // POST: AdvProjComments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommentId,CommentTitle,CommentBody,CommentDate,TaskId,UserId,ResponseId")] AdvProjComment advProjComment)
        {
            AdvProjComment actComm = advProjComment;
            if (ModelState.IsValid)
            {
                int tid = Convert.ToInt32(TempData["tid"]);

                actComm.UserId = Global.userID;
                actComm.CommentDate = DateTime.Now;
                actComm.TaskId = tid;

                _context.Add(advProjComment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { tid = tid });
            }
            ViewData["ResponseId"] = new SelectList(_context.AdvProjComResponses, "ResponseId", "ResponseName", advProjComment.ResponseId);
            return View(advProjComment);
        }

        // GET: AdvProjComments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjComments == null)
            {
                return NotFound();
            }

            var advProjComment = await _context.AdvProjComments.FindAsync(id);
            if (advProjComment == null)
            {
                return NotFound();
            }

            ViewData["ResponseId"] = new SelectList(_context.AdvProjComResponses, "ResponseId", "ResponseName", advProjComment.ResponseId);

            return View(advProjComment);
        }

        // POST: AdvProjComments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommentId,CommentTitle,CommentBody,CommentDate,TaskId,UserId,ResponseId")] AdvProjComment advProjComment)
        {
            if (id != advProjComment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var tid = advProjComment.TaskId;
                try
                {
                    _context.Update(advProjComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjCommentExists(advProjComment.CommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { tid = tid });
            }
            ViewData["ResponseId"] = new SelectList(_context.AdvProjComResponses, "ResponseId", "ResponseName", advProjComment.ResponseId);
            return View(advProjComment);
        }

        // GET: AdvProjComments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjComments == null)
            {
                return NotFound();
            }

            var advProjComment = await _context.AdvProjComments
                .Include(a => a.Response)
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (advProjComment == null)
            {
                return NotFound();
            }

            return View(advProjComment);
        }

        // POST: AdvProjComments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjComments == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjComments'  is null.");
            }
            var advProjComment = await _context.AdvProjComments.FindAsync(id);
            var tid = advProjComment.TaskId;

            if (advProjComment != null)
            {
                _context.AdvProjComments.Remove(advProjComment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { tid = tid });
        }

        private bool AdvProjCommentExists(int id)
        {
          return (_context.AdvProjComments?.Any(e => e.CommentId == id)).GetValueOrDefault();
        }
    }
}
