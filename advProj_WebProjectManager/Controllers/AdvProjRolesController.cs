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
    public class AdvProjRolesController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjRolesController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjRoles
        public async Task<IActionResult> Index()
        {
              return _context.AdvProjRoles != null ? 
                          View(await _context.AdvProjRoles.ToListAsync()) :
                          Problem("Entity set 'AdvProg_DatabaseContext.AdvProjRoles'  is null.");
        }

        // GET: AdvProjRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjRoles == null)
            {
                return NotFound();
            }

            var advProjRole = await _context.AdvProjRoles
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (advProjRole == null)
            {
                return NotFound();
            }

            return View(advProjRole);
        }

        // GET: AdvProjRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdvProjRoles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoleId,RoleName,RoleDescription")] AdvProjRole advProjRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advProjRole);
        }

        // GET: AdvProjRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjRoles == null)
            {
                return NotFound();
            }

            var advProjRole = await _context.AdvProjRoles.FindAsync(id);
            if (advProjRole == null)
            {
                return NotFound();
            }
            return View(advProjRole);
        }

        // POST: AdvProjRoles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoleId,RoleName,RoleDescription")] AdvProjRole advProjRole)
        {
            if (id != advProjRole.RoleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjRoleExists(advProjRole.RoleId))
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
            return View(advProjRole);
        }

        // GET: AdvProjRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjRoles == null)
            {
                return NotFound();
            }

            var advProjRole = await _context.AdvProjRoles
                .FirstOrDefaultAsync(m => m.RoleId == id);
            if (advProjRole == null)
            {
                return NotFound();
            }

            return View(advProjRole);
        }

        // POST: AdvProjRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjRoles == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjRoles'  is null.");
            }
            var advProjRole = await _context.AdvProjRoles.FindAsync(id);
            if (advProjRole != null)
            {
                _context.AdvProjRoles.Remove(advProjRole);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjRoleExists(int id)
        {
          return (_context.AdvProjRoles?.Any(e => e.RoleId == id)).GetValueOrDefault();
        }
    }
}
