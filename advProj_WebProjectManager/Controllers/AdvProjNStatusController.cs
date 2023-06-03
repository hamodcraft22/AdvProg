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
    public class AdvProjNStatusController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjNStatusController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjNStatus
        public async Task<IActionResult> Index()
        {
              return _context.AdvProjNStatuses != null ? 
                          View(await _context.AdvProjNStatuses.ToListAsync()) :
                          Problem("Entity set 'AdvProg_DatabaseContext.AdvProjNStatuses'  is null.");
        }

        // GET: AdvProjNStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjNStatuses == null)
            {
                return NotFound();
            }

            var advProjNStatus = await _context.AdvProjNStatuses
                .FirstOrDefaultAsync(m => m.StatusId == id);
            if (advProjNStatus == null)
            {
                return NotFound();
            }

            return View(advProjNStatus);
        }

        // GET: AdvProjNStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdvProjNStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatusId,StatusName,StatusDescription")] AdvProjNStatus advProjNStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjNStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advProjNStatus);
        }

        // GET: AdvProjNStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjNStatuses == null)
            {
                return NotFound();
            }

            var advProjNStatus = await _context.AdvProjNStatuses.FindAsync(id);
            if (advProjNStatus == null)
            {
                return NotFound();
            }
            return View(advProjNStatus);
        }

        // POST: AdvProjNStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StatusId,StatusName,StatusDescription")] AdvProjNStatus advProjNStatus)
        {
            if (id != advProjNStatus.StatusId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjNStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjNStatusExists(advProjNStatus.StatusId))
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
            return View(advProjNStatus);
        }

        // GET: AdvProjNStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjNStatuses == null)
            {
                return NotFound();
            }

            var advProjNStatus = await _context.AdvProjNStatuses
                .FirstOrDefaultAsync(m => m.StatusId == id);
            if (advProjNStatus == null)
            {
                return NotFound();
            }

            return View(advProjNStatus);
        }

        // POST: AdvProjNStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjNStatuses == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjNStatuses'  is null.");
            }
            var advProjNStatus = await _context.AdvProjNStatuses.FindAsync(id);
            if (advProjNStatus != null)
            {
                _context.AdvProjNStatuses.Remove(advProjNStatus);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjNStatusExists(int id)
        {
          return (_context.AdvProjNStatuses?.Any(e => e.StatusId == id)).GetValueOrDefault();
        }
    }
}
