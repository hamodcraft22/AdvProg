using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using advProj_BusinessObjects;
using Microsoft.AspNetCore.Authorization;

namespace advProj_WebProjectManager.Controllers
{
    [Authorize(Roles = "Admin")]
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
    }
}
