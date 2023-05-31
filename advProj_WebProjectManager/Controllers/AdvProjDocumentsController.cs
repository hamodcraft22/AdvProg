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
    public class AdvProjDocumentsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjDocumentsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjDocuments
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjDocuments.Include(a => a.Task).Include(a => a.User);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjDocuments/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: AdvProjDocuments/Create
        public IActionResult Create()
        {
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription");
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId");
            return View();
        }

        // POST: AdvProjDocuments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DocumentId,DocumentName,DocumentType,DocumentExt,DocumentPath,DocumentDescription,UploadDate,TaskId,UserId")] AdvProjDocument advProjDocument)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjDocument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjDocument.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjDocument.UserId);
            return View(advProjDocument);
        }

        // GET: AdvProjDocuments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjDocuments == null)
            {
                return NotFound();
            }

            var advProjDocument = await _context.AdvProjDocuments.FindAsync(id);
            if (advProjDocument == null)
            {
                return NotFound();
            }
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjDocument.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjDocument.UserId);
            return View(advProjDocument);
        }

        // POST: AdvProjDocuments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DocumentId,DocumentName,DocumentType,DocumentExt,DocumentPath,DocumentDescription,UploadDate,TaskId,UserId")] AdvProjDocument advProjDocument)
        {
            if (id != advProjDocument.DocumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjDocument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjDocumentExists(advProjDocument.DocumentId))
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
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjDocument.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjDocument.UserId);
            return View(advProjDocument);
        }

        // GET: AdvProjDocuments/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: AdvProjDocuments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
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
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjDocumentExists(int id)
        {
          return (_context.AdvProjDocuments?.Any(e => e.DocumentId == id)).GetValueOrDefault();
        }
    }
}
