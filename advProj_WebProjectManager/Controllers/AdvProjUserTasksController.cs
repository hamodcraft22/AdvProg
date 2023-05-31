using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;

namespace advProj_WebProjectManager.Controllers
{
    public class AdvProjUserTasksController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjUserTasksController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjUserTasks
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjUserTasks.Include(a => a.Status).Include(a => a.Task).Include(a => a.User);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjUserTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjUserTasks == null)
            {
                return NotFound();
            }

            var advProjUserTask = await _context.AdvProjUserTasks
                .Include(a => a.Status)
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.UserTaskId == id);
            if (advProjUserTask == null)
            {
                return NotFound();
            }

            return View(advProjUserTask);
        }

        // GET: AdvProjUserTasks/Create
        public IActionResult Create()
        {
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription");
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription");
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId");
            return View();
        }

        // POST: AdvProjUserTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserTaskId,Objective,StartDate,EndDate,StatusId,UserId,TaskId")] AdvProjUserTask advProjUserTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjUserTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjUserTask.StatusId);
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjUserTask.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjUserTask.UserId);
            return View(advProjUserTask);
        }

        // GET: AdvProjUserTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjUserTasks == null)
            {
                return NotFound();
            }

            var advProjUserTask = await _context.AdvProjUserTasks.FindAsync(id);
            if (advProjUserTask == null)
            {
                return NotFound();
            }
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjUserTask.StatusId);
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjUserTask.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjUserTask.UserId);
            return View(advProjUserTask);
        }

        // POST: AdvProjUserTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserTaskId,Objective,StartDate,EndDate,StatusId,UserId,TaskId")] AdvProjUserTask advProjUserTask)
        {
            if (id != advProjUserTask.UserTaskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjUserTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjUserTaskExists(advProjUserTask.UserTaskId))
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
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjUserTask.StatusId);
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjUserTask.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjUserTask.UserId);
            return View(advProjUserTask);
        }

        // GET: AdvProjUserTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjUserTasks == null)
            {
                return NotFound();
            }

            var advProjUserTask = await _context.AdvProjUserTasks
                .Include(a => a.Status)
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.UserTaskId == id);
            if (advProjUserTask == null)
            {
                return NotFound();
            }

            return View(advProjUserTask);
        }

        // POST: AdvProjUserTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjUserTasks == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjUserTasks'  is null.");
            }
            var advProjUserTask = await _context.AdvProjUserTasks.FindAsync(id);
            if (advProjUserTask != null)
            {
                _context.AdvProjUserTasks.Remove(advProjUserTask);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjUserTaskExists(int id)
        {
          return (_context.AdvProjUserTasks?.Any(e => e.UserTaskId == id)).GetValueOrDefault();
        }
    }
}
