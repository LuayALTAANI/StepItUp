using Microsoft.AspNetCore.Mvc;
using StepItUp.Data;
using StepItUp.Models;

namespace StepItUp.Controllers
{
	public class ShopController : Controller
	{
		private readonly ApplicationDbContext _context; 
		
		public ShopController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var categories = _context.Category.OrderBy(x => x.Name).ToList();
			return View(categories);
		}

		public IActionResult Category(int? id)
		{
			//Use id para in URL to fitvh seection Category
			ViewData["Category"] = "CategoryId: " + id;
			return View();
		}
	}
}
