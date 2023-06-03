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
    public class AdvProjPStatusController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjPStatusController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjPStatus
        public async Task<IActionResult> Index()
        {
              return _context.AdvProjPStatuses != null ? 
                          View(await _context.AdvProjPStatuses.ToListAsync()) :
                          Problem("Entity set 'AdvProg_DatabaseContext.AdvProjPStatuses'  is null.");
        }

        // GET: AdvProjPStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjPStatuses == null)
            {
                return NotFound();
            }

            var advProjPStatus = await _context.AdvProjPStatuses
                .FirstOrDefaultAsync(m => m.StatusId == id);
            if (advProjPStatus == null)
            {
                return NotFound();
            }

            return View(advProjPStatus);
        }

        // GET: AdvProjPStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdvProjPStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatusId,StatusName,StatusDescription")] AdvProjPStatus advProjPStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjPStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advProjPStatus);
        }

        // GET: AdvProjPStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjPStatuses == null)
            {
                return NotFound();
            }

            var advProjPStatus = await _context.AdvProjPStatuses.FindAsync(id);
            if (advProjPStatus == null)
            {
                return NotFound();
            }
            return View(advProjPStatus);
        }

        // POST: AdvProjPStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StatusId,StatusName,StatusDescription")] AdvProjPStatus advProjPStatus)
        {
            if (id != advProjPStatus.StatusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjPStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjPStatusExists(advProjPStatus.StatusId))
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
            return View(advProjPStatus);
        }

        // GET: AdvProjPStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjPStatuses == null)
            {
                return NotFound();
            }

            var advProjPStatus = await _context.AdvProjPStatuses
                .FirstOrDefaultAsync(m => m.StatusId == id);
            if (advProjPStatus == null)
            {
                return NotFound();
            }

            return View(advProjPStatus);
        }

        // POST: AdvProjPStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjPStatuses == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjPStatuses'  is null.");
            }
            var advProjPStatus = await _context.AdvProjPStatuses.FindAsync(id);
            if (advProjPStatus != null)
            {
                _context.AdvProjPStatuses.Remove(advProjPStatus);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjPStatusExists(int id)
        {
          return (_context.AdvProjPStatuses?.Any(e => e.StatusId == id)).GetValueOrDefault();
        }
    }
}
