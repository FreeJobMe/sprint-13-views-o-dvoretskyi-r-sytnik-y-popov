using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.UI.Controllers
{
	public class TasksController : Controller
	{
		private IRepository<User> _userRepository;
		private IRepository<Order> _orderRepository;
		private IRepository<Shop> _shopRepository;
		private IRepository<Product> _productRepository;

		public TasksController(
			IRepository<User> userRepository,
			IRepository<Order> orderRepository,
			IRepository<Shop> shopRepository,
			IRepository<Product> productRepository)
		{
			_userRepository = userRepository;
			_orderRepository = orderRepository;
			_shopRepository = shopRepository;
			_productRepository = productRepository;
		}

		public IActionResult ShoppingCart()
		{
			return View("ShoppingCart", 
				(_shopRepository.GetAll().ToDictionary(s => s.Id, s => s.Title), 
				_productRepository.GetAll().ToDictionary(s => s.Id, s => s.Title)));
		}

		[HttpPost]
		public IActionResult AddOrder(string fullName, string address, int shopId, DateTime dateTime, int productId)
		{
			ViewBag.Message = "Your products will be shipped at: " + address + ". Bon appetite, " + fullName + "!";
			return View("ShoppingCart");
		}

		public IActionResult ShoppingCarts()
		{
			var usersBaskets = new Dictionary<string, Dictionary<int, DateTime>>();
			foreach (var user in _userRepository.GetAll())
			{
				var baskets = new Dictionary<int, DateTime>();
				foreach (var basket in user.Baskets.Where(b => b.OrderId == 0))
					baskets.Add(basket.Id, basket.DateTime);

				if (baskets.Count > 0)
					usersBaskets.Add(user.FullName, baskets);
			}
			return View("ShoppingCarts", usersBaskets);
		}
	}

    public class TasksController : Controller
    {
        public IActionResult SprintTasks()
        {
            return View();
        }
        public IActionResult Greetings()
        {
            ViewBag.Value = "C# Marathon!";
            ViewBag.Greeting = "Welcome to our project!";
            return View();
        }
    }
}
