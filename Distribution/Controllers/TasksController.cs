using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using Distribution.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

		public IActionResult ShoppingList()
		{
			var shoppingListOfUsers = new List<ShoppingListModel>();
			foreach (var user in _userRepository.GetAll())
			{
				var shoppingListOfUser = new ShoppingListModel() { FullName = user.FullName };
				foreach (var basket in user.Baskets)
				{
					shoppingListOfUser.Baskets.Add(basket.BasketItems);
				}
				shoppingListOfUsers.Add(shoppingListOfUser);
			}
			return View(shoppingListOfUsers);
		}

		public IActionResult SuperMarkets()
		{
			var shopModels = new List<ShopModel>();
			foreach (var shop in _shopRepository.GetAll())
			{
				var shopModel = new ShopModel() { Title = shop.Title };

				foreach (var position in shop.Positions)
					if (position.Amount > 0)
						shopModel.Positions.Add(position);

				shopModels.Add(shopModel);
			}
			return View(shopModels);
		}

		public IActionResult ProductInfo()
		{
			var productsShops = new List<ProductShopsModel>();
			foreach (var product in _productRepository.GetAll())
			{
				var productShops = new ProductShopsModel()
				{
					Title = product.Title,
					Price = product.Price
				};

				foreach (var shop in _shopRepository.GetAll())
				{
					var amount = shop.Positions.FirstOrDefault(p => p.Product == product)?.Amount ?? 0;
					if (amount > 0)
						productShops.ShopProductAmounts.Add(shop.Title, amount);
				}

				productsShops.Add(productShops);
			}
			return View(productsShops);
		}
	}
}
