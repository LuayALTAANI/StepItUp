using Microsoft.AspNetCore.Mvc;
using StepItUp.Models;

namespace StepItUp.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			// creeat a mock up categories list and pass it to the view

			List<Category> categories = new List<Category>();

			//populate mock p list
			for (int i = 1; i < 11; i++)
			{
				categories.Add(new Category { CategoriesId = i, Name = "name "+i });
			}
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
