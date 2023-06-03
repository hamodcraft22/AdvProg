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
    public class AdvProjLogsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjLogsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjLogs
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjLogs.Include(a => a.User);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjLogs == null)
            {
                return NotFound();
            }

            var advProjLog = await _context.AdvProjLogs
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.LogId == id);
            if (advProjLog == null)
            {
                return NotFound();
            }

            return View(advProjLog);
        }

        // GET: AdvProjLogs/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId");
            return View();
        }

        // POST: AdvProjLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LogId,LogSource,ExceptionMsg,Date,UserId")] AdvProjLog advProjLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjLog.UserId);
            return View(advProjLog);
        }

        // GET: AdvProjLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjLogs == null)
            {
                return NotFound();
            }

            var advProjLog = await _context.AdvProjLogs.FindAsync(id);
            if (advProjLog == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjLog.UserId);
            return View(advProjLog);
        }

        // POST: AdvProjLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LogId,LogSource,ExceptionMsg,Date,UserId")] AdvProjLog advProjLog)
        {
            if (id != advProjLog.LogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjLogExists(advProjLog.LogId))
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
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjLog.UserId);
            return View(advProjLog);
        }

        // GET: AdvProjLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjLogs == null)
            {
                return NotFound();
            }

            var advProjLog = await _context.AdvProjLogs
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.LogId == id);
            if (advProjLog == null)
            {
                return NotFound();
            }

            return View(advProjLog);
        }

        // POST: AdvProjLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjLogs == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjLogs'  is null.");
            }
            var advProjLog = await _context.AdvProjLogs.FindAsync(id);
            if (advProjLog != null)
            {
                _context.AdvProjLogs.Remove(advProjLog);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjLogExists(int id)
        {
          return (_context.AdvProjLogs?.Any(e => e.LogId == id)).GetValueOrDefault();
        }
    }
}
