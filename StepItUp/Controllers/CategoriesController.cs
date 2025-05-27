using Microsoft.AspNetCore.Mvc;
using StepItUp.Data;
using StepItUp.Models;

namespace StepItUp.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CategoriesController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var categories = _context.Category.OrderBy(x => x.Name).ToList();
			return View(categories);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create([Bind("Name")] Category category)
		{
			_context.Category.Add(category);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
