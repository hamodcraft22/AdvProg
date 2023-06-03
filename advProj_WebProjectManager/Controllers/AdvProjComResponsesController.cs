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
    public class AdvProjComResponsesController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjComResponsesController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjComResponses
        public async Task<IActionResult> Index()
        {
              return _context.AdvProjComResponses != null ? 
                          View(await _context.AdvProjComResponses.ToListAsync()) :
                          Problem("Entity set 'AdvProg_DatabaseContext.AdvProjComResponses'  is null.");
        }

        // GET: AdvProjComResponses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjComResponses == null)
            {
                return NotFound();
            }

            var advProjComResponse = await _context.AdvProjComResponses
                .FirstOrDefaultAsync(m => m.ResponseId == id);
            if (advProjComResponse == null)
            {
                return NotFound();
            }

            return View(advProjComResponse);
        }

        // GET: AdvProjComResponses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdvProjComResponses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResponseId,ResponseName,ResponseDescription")] AdvProjComResponse advProjComResponse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjComResponse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advProjComResponse);
        }

        // GET: AdvProjComResponses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjComResponses == null)
            {
                return NotFound();
            }

            var advProjComResponse = await _context.AdvProjComResponses.FindAsync(id);
            if (advProjComResponse == null)
            {
                return NotFound();
            }
            return View(advProjComResponse);
        }

        // POST: AdvProjComResponses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResponseId,ResponseName,ResponseDescription")] AdvProjComResponse advProjComResponse)
        {
            if (id != advProjComResponse.ResponseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjComResponse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjComResponseExists(advProjComResponse.ResponseId))
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
            return View(advProjComResponse);
        }

        // GET: AdvProjComResponses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjComResponses == null)
            {
                return NotFound();
            }

            var advProjComResponse = await _context.AdvProjComResponses
                .FirstOrDefaultAsync(m => m.ResponseId == id);
            if (advProjComResponse == null)
            {
                return NotFound();
            }

            return View(advProjComResponse);
        }

        // POST: AdvProjComResponses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjComResponses == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjComResponses'  is null.");
            }
            var advProjComResponse = await _context.AdvProjComResponses.FindAsync(id);
            if (advProjComResponse != null)
            {
                _context.AdvProjComResponses.Remove(advProjComResponse);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjComResponseExists(int id)
        {
          return (_context.AdvProjComResponses?.Any(e => e.ResponseId == id)).GetValueOrDefault();
        }
    }
}
