using Microsoft.AspNetCore.Mvc;
using StepItUp.Models;

namespace StepItUp.Controllers
{
	public class CategoriesController : Controller
	{
		public IActionResult Index()
		{
			//creeat a mock up categories list and pass it to the view

		 List<Category> categories = new List<Category>();

			//populate mock p list
			for (int i = 1; i < 11; i++)
			{
				categories.Add(new Category { CategoriesId = i, Name = "a name" });
			}
			return View(categories);
		}

		public IActionResult Create()
		{
			return View();
		}
	}
}
