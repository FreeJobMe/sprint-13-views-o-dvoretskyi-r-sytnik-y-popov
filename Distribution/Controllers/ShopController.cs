using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure;
using Distribution.DAL.Infrastructure.Interfaces;
using Distribution.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.UI.Controllers
{
	public class ShopController : Controller
	{
		private IRepository<Shop> _shopRepository;

		public ShopController(IRepository<Shop> shopRepository)
		{
			_shopRepository = shopRepository;
		}

		public IActionResult Info()
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
	}
}
