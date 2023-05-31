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
    public class AdvProjProjectsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjProjectsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjProjects
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjProjects.Include(a => a.Manager).Include(a => a.Status);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjProjects == null)
            {
                return NotFound();
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

        // GET: AdvProjProjects/Create
        public IActionResult Create()
        {
            ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId");
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName");
            return View();
        }

        // POST: AdvProjProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,ProjectName,ProjectDescription,CreateDate,StartDate,EndDate,FinishDate,StatusId,ManagerId")] AdvProjProject advProjProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjProject.ManagerId);
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusName", advProjProject.StatusId);
            return View(advProjProject);
        }

        // GET: AdvProjProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjProjects == null)
            {
                return NotFound();
            }

            var advProjProject = await _context.AdvProjProjects.FindAsync(id);
            if (advProjProject == null)
            {
                return NotFound();
            }
            ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjProject.ManagerId);
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjProject.StatusId);
            return View(advProjProject);
        }

        // POST: AdvProjProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,ProjectName,ProjectDescription,CreateDate,StartDate,EndDate,FinishDate,StatusId,ManagerId")] AdvProjProject advProjProject)
        {
            if (id != advProjProject.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjProjectExists(advProjProject.ProjectId))
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
            ViewData["ManagerId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjProject.ManagerId);
            ViewData["StatusId"] = new SelectList(_context.AdvProjPStatuses, "StatusId", "StatusDescription", advProjProject.StatusId);
            return View(advProjProject);
        }

        // GET: AdvProjProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjProjects == null)
            {
                return NotFound();
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

        // POST: AdvProjProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
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
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjProjectExists(int id)
        {
          return (_context.AdvProjProjects?.Any(e => e.ProjectId == id)).GetValueOrDefault();
        }
    }
}
