using Distribution.DAL.Infrastructure.Interfaces;
using Distribution.Models;
using Distribution.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.UI.Controllers
{
	public class ProductController : Controller
	{
		private IPositionRepository _positionRepository;
		private IProductRepository _productRepository;
		private IShopRepository _shopRepository;

		public ProductController(IPositionRepository positionRepository, IProductRepository productRepository, IShopRepository shopRepository)
		{
			_positionRepository = positionRepository;
			_productRepository = productRepository;
			_shopRepository = shopRepository;
		}

		public IActionResult Info()
		{
			var productsShops = new List<ProductShopsModel>();
			foreach (var product in _productRepository.GetAllProducts())
			{
				var productShops = new ProductShopsModel() { Title = product.Title, 
															 Price = product.Price};
				foreach (var shop in _shopRepository.GetAllShops())
				{
					var amount = shop.Positions.FirstOrDefault(p => p.Product == product)?.Amount ?? 0;
					if (amount > 0)
						productShops.ShopProductAmounts.Add(shop.Title, amount);
				}
				if (productShops.ShopProductAmounts.Count > 0)
					productsShops.Add(productShops);
			}
			return View(productsShops);
		}
	}
}
