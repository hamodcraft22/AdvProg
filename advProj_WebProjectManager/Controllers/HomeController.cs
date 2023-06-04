using advProj_BusinessObjects;
using advProj_WebProjectManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace advProj_WebProjectManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdvProg_DatabaseContext _dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = new AdvProg_DatabaseContext();
        }

        public IActionResult Index()
        {
            //returning stats to home 
            int NoOfProjects = _dbContext.AdvProjProjects.Count();
            int NoOfTasks = _dbContext.AdvProjTasks.Count();
            int NoOfUsers = _dbContext.AdvProjUsers.Count();
            int NoOfComs = _dbContext.AdvProjComments.Count();

            ViewData["NoOfProjects"] = NoOfProjects;
            ViewData["NoOfTasks"] = NoOfTasks;
            ViewData["NoOfUsers"] = NoOfUsers;
            ViewData["NoOfComs"] = NoOfComs;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}