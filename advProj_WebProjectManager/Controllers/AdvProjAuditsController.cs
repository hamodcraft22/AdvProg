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
    public class AdvProjAuditsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjAuditsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjAudits
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjAudits.Include(a => a.User);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjAudits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjAudits == null)
            {
                return NotFound();
            }

            var advProjAudit = await _context.AdvProjAudits
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.AuditId == id);
            if (advProjAudit == null)
            {
                return NotFound();
            }

            return View(advProjAudit);
        }

        // GET: AdvProjAudits/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId");
            return View();
        }

        // POST: AdvProjAudits/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuditId,AuditSource,ChnageType,EntityName,OldValue,NewValue,RecordId,UserId")] AdvProjAudit advProjAudit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjAudit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjAudit.UserId);
            return View(advProjAudit);
        }

        // GET: AdvProjAudits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjAudits == null)
            {
                return NotFound();
            }

            var advProjAudit = await _context.AdvProjAudits.FindAsync(id);
            if (advProjAudit == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjAudit.UserId);
            return View(advProjAudit);
        }

        // POST: AdvProjAudits/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuditId,AuditSource,ChnageType,EntityName,OldValue,NewValue,RecordId,UserId")] AdvProjAudit advProjAudit)
        {
            if (id != advProjAudit.AuditId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjAudit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjAuditExists(advProjAudit.AuditId))
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
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjAudit.UserId);
            return View(advProjAudit);
        }

        // GET: AdvProjAudits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjAudits == null)
            {
                return NotFound();
            }

            var advProjAudit = await _context.AdvProjAudits
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.AuditId == id);
            if (advProjAudit == null)
            {
                return NotFound();
            }

            return View(advProjAudit);
        }

        // POST: AdvProjAudits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjAudits == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjAudits'  is null.");
            }
            var advProjAudit = await _context.AdvProjAudits.FindAsync(id);
            if (advProjAudit != null)
            {
                _context.AdvProjAudits.Remove(advProjAudit);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjAuditExists(int id)
        {
          return (_context.AdvProjAudits?.Any(e => e.AuditId == id)).GetValueOrDefault();
        }
    }
}
