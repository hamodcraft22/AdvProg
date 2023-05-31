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
    public class AdvProjUsersController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjUsersController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjUsers
        public async Task<IActionResult> Index()
        {
              return _context.AdvProjUsers != null ? 
                          View(await _context.AdvProjUsers.ToListAsync()) :
                          Problem("Entity set 'AdvProg_DatabaseContext.AdvProjUsers'  is null.");
        }

        // GET: AdvProjUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjUsers == null)
            {
                return NotFound();
            }

            var advProjUser = await _context.AdvProjUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (advProjUser == null)
            {
                return NotFound();
            }

            return View(advProjUser);
        }

        // GET: AdvProjUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdvProjUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,AspUserId,RoleId")] AdvProjUser advProjUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(advProjUser);
        }

        // GET: AdvProjUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjUsers == null)
            {
                return NotFound();
            }

            var advProjUser = await _context.AdvProjUsers.FindAsync(id);
            if (advProjUser == null)
            {
                return NotFound();
            }
            return View(advProjUser);
        }

        // POST: AdvProjUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,AspUserId,RoleId")] AdvProjUser advProjUser)
        {
            if (id != advProjUser.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjUserExists(advProjUser.UserId))
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
            return View(advProjUser);
        }

        // GET: AdvProjUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjUsers == null)
            {
                return NotFound();
            }

            var advProjUser = await _context.AdvProjUsers
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (advProjUser == null)
            {
                return NotFound();
            }

            return View(advProjUser);
        }

        // POST: AdvProjUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjUsers == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjUsers'  is null.");
            }
            var advProjUser = await _context.AdvProjUsers.FindAsync(id);
            if (advProjUser != null)
            {
                _context.AdvProjUsers.Remove(advProjUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjUserExists(int id)
        {
          return (_context.AdvProjUsers?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
