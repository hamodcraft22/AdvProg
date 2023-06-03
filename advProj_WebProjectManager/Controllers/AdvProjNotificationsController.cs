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
    public class AdvProjNotificationsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjNotificationsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjNotifications
        public async Task<IActionResult> Index()
        {
            var advProg_DatabaseContext = _context.AdvProjNotifications.Include(a => a.Status).Include(a => a.Task).Include(a => a.User);
            return View(await advProg_DatabaseContext.ToListAsync());
        }

        // GET: AdvProjNotifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AdvProjNotifications == null)
            {
                return NotFound();
            }

            var advProjNotification = await _context.AdvProjNotifications
                .Include(a => a.Status)
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.NotificationId == id);
            if (advProjNotification == null)
            {
                return NotFound();
            }

            return View(advProjNotification);
        }

        // GET: AdvProjNotifications/Create
        public IActionResult Create()
        {
            ViewData["StatusId"] = new SelectList(_context.AdvProjNStatuses, "StatusId", "StatusDescription");
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription");
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId");
            return View();
        }

        // POST: AdvProjNotifications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NotificationId,NotificationTitle,NotificationDate,NotificationBody,StatusId,UserId,TaskId")] AdvProjNotification advProjNotification)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advProjNotification);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatusId"] = new SelectList(_context.AdvProjNStatuses, "StatusId", "StatusDescription", advProjNotification.StatusId);
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjNotification.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjNotification.UserId);
            return View(advProjNotification);
        }

        // GET: AdvProjNotifications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AdvProjNotifications == null)
            {
                return NotFound();
            }

            var advProjNotification = await _context.AdvProjNotifications.FindAsync(id);
            if (advProjNotification == null)
            {
                return NotFound();
            }
            ViewData["StatusId"] = new SelectList(_context.AdvProjNStatuses, "StatusId", "StatusDescription", advProjNotification.StatusId);
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjNotification.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjNotification.UserId);
            return View(advProjNotification);
        }

        // POST: AdvProjNotifications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NotificationId,NotificationTitle,NotificationDate,NotificationBody,StatusId,UserId,TaskId")] AdvProjNotification advProjNotification)
        {
            if (id != advProjNotification.NotificationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advProjNotification);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvProjNotificationExists(advProjNotification.NotificationId))
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
            ViewData["StatusId"] = new SelectList(_context.AdvProjNStatuses, "StatusId", "StatusDescription", advProjNotification.StatusId);
            ViewData["TaskId"] = new SelectList(_context.AdvProjTasks, "TaskId", "TaskDescription", advProjNotification.TaskId);
            ViewData["UserId"] = new SelectList(_context.AdvProjUsers, "UserId", "UserId", advProjNotification.UserId);
            return View(advProjNotification);
        }

        // GET: AdvProjNotifications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AdvProjNotifications == null)
            {
                return NotFound();
            }

            var advProjNotification = await _context.AdvProjNotifications
                .Include(a => a.Status)
                .Include(a => a.Task)
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.NotificationId == id);
            if (advProjNotification == null)
            {
                return NotFound();
            }

            return View(advProjNotification);
        }

        // POST: AdvProjNotifications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AdvProjNotifications == null)
            {
                return Problem("Entity set 'AdvProg_DatabaseContext.AdvProjNotifications'  is null.");
            }
            var advProjNotification = await _context.AdvProjNotifications.FindAsync(id);
            if (advProjNotification != null)
            {
                _context.AdvProjNotifications.Remove(advProjNotification);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvProjNotificationExists(int id)
        {
          return (_context.AdvProjNotifications?.Any(e => e.NotificationId == id)).GetValueOrDefault();
        }
    }
}
