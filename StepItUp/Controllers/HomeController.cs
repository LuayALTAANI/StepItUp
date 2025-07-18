using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StepItUp.Models;

namespace StepItUp.Controllers
{
    public class HomeController : Controller
    {

		public IActionResult About()
		{
			ViewData["TimeStamp"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			return View();
		}

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
