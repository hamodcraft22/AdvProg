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
    public class AdvProjTasksController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjTasksController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjTasks
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjTasks.Include(a => a.Project).Include(a => a.Status);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjTasks == null)
            {
                return NotFound();
            }

            var advProjTask = await _context.AdvProjTasks
                .Include(a => a.Project)
                .Include(a => a.Status)
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (advProjTask == null)
            {
                return NotFound();
            }

            return View(advProjTask);
        }

        // GET: AdvProjTasks/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.AdvProjProjects, "ProjectId", "ProjectDescription");
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription");
            return View();
        }

        // POST: AdvProjTasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskId,TaskName,TaskDescription,CreateDate,StartDate,EndDate,FinishDate,StatusId,ProjectId")] AdvProjTask advProjTask)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.AdvProjProjects, "ProjectId", "ProjectDescription", advProjTask.ProjectId);
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjTask.StatusId);
            return View(advProjTask);
        }

        // GET: AdvProjTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjTasks == null)
            {
                return NotFound();
            }

            var advProjTask = await _context.AdvProjTasks.FindAsync(id);
            if (advProjTask == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.AdvProjProjects, "ProjectId", "ProjectDescription", advProjTask.ProjectId);
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjTask.StatusId);
            return View(advProjTask);
        }

        // POST: AdvProjTasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskId,TaskName,TaskDescription,CreateDate,StartDate,EndDate,FinishDate,StatusId,ProjectId")] AdvProjTask advProjTask)
        {
            if (id != advProjTask.TaskId)
            {
                return NotFound();
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.AdvProjProjects, "ProjectId", "ProjectDescription", advProjTask.ProjectId);
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjTask.StatusId);
            return View(advProjTask);
        }

        // GET: AdvProjTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjTasks == null)
            {
                return NotFound();
            }

            var advProjTask = await _context.AdvProjTasks
                .Include(a => a.Project)
                .Include(a => a.Status)
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (advProjTask == null)
            {
                return NotFound();
            }

            return View(advProjTask);
        }

        // POST: AdvProjTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjTasks == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjTasks'  is null.");
            }
            var advProjTask = await _context.AdvProjTasks.FindAsync(id);
            if (advProjTask != null)
            {
                _context.AdvProjTasks.Remove(advProjTask);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjTaskExists(int id)
        {
          return (_context.AdvProjTasks?.Any(e => e.TaskId == id)).GetValueOrDefault();
        }
    }
}
