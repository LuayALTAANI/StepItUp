﻿using Microsoft.AspNetCore.Mvc;

namespace StepItUp.Controllers
{
	public class ProductsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}
		public IActionResult Edit()
		{
			return View();
		}
		public IActionResult Delete()
		{
			return View();
		}

	}
}
