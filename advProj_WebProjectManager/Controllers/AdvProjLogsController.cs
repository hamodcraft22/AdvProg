using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace advProj_WebProjectManager.Controllers
{
    [Authorize(Roles = "Admin")]
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
    }
}
