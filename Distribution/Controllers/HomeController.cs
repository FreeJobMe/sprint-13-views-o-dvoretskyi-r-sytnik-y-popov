using Distribution.DAL.Infrastructure;
using Distribution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private InitialData _initialData;
		private bool isInitializedData = false;

		public HomeController(ILogger<HomeController> logger, InitialData initialData)
		{
			_logger = logger;
			_initialData = initialData;
		}

		public IActionResult Index()
		{
			InitialData();
			return View();
		}

		public IActionResult InitialData()
		{
			if (!isInitializedData)
			{
				isInitializedData = true;
				_initialData.FillProductRepository();
				_initialData.FillShopRepository();
				_initialData.FillUserRepository();
			}

			return View("Index");
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
