using CoreMvcCodeFirst_1.Models;
using CoreMvcCodeFirst_1.Models.ContextClasses;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreMvcCodeFirst_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        MyContext _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        //Actionlar'da bir parametre bulunuyorsa bu demektir ki o Action o parametreyi ModelBinding yöntemiyle veya get'teki route-data yöntemiyle alacaktır...

        public IActionResult Index()
        {
          
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
