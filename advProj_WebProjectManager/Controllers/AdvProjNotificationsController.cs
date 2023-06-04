using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using advProj_WebProjectManager.Models;
using Microsoft.AspNetCore.Authorization;
using advProj_BusinessObjects.GlobalClass;

namespace advProj_WebProjectManager.Controllers
{
    [Authorize]
    public class AdvProjNotificationsController : Controller
    {
        private readonly AdvProg_DatabaseContext _context;

        public AdvProjNotificationsController(AdvProg_DatabaseContext context)
        {
            _context = context;
        }

        // GET: AdvProjNotifications
        public async Task<IActionResult> Index(string? unread)
        {



            try
            {
                var advProg_DatabaseContext = _context.AdvProjNotifications.Include(a => a.Status).Include(a => a.Task).Include(a => a.User).Include(z => z.Task.Project).Where(b => b.UserId == Global.userID);

                if (unread != null)
                {
                    advProg_DatabaseContext = advProg_DatabaseContext.Where(a => a.StatusId == 1);
                }

                return View(await advProg_DatabaseContext.OrderByDescending(x => x.NotificationDate).ToListAsync());
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }

        // GET: AdvProjNotifications/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            try
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

                // set the notification as read
                advProjNotification.StatusId = 2;
                _context.Update(advProjNotification);
                _context.SaveChanges();

                return View(advProjNotification);
            }
            catch (Exception ex)
            {
                // creating and saving excpetion log
                LogsAudits.addLog("Web", ex.Message.ToString(), (int)Global.userID);

                // return to home page with error 
                TempData["ErrorMsg"] = "An Error Has Occured, Please Try Again Later";
                return RedirectToAction("Index", "Home", new { area = "" });

            }
        }


        private bool AdvProjNotificationExists(int id)
        {
            return (_context.AdvProjNotifications?.Any(e => e.NotificationId == id)).GetValueOrDefault();
        }
    }
}
