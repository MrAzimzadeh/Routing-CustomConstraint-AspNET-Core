using CustomConstraint.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomConstraint.Controllers
{
    [Route("Esas")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("in")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("pr")]
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