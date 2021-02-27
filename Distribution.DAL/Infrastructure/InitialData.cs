using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
	public class InitialData
	{
		private IRepository<Basket> _basketRepository;
		private IRepository<BasketItem> _basketItemRepository;
		private IRepository<Position> _positionRepository;
		private IRepository<Product> _productRepository;
		private IRepository<Shop> _shopRepository;
		private IRepository<User> _userRepository;

		private Random random = new Random();

		public InitialData(
			IRepository<Basket> basketRepository,
			IRepository<BasketItem> basketItemRepository,
			IRepository<Position> positionRepository,
			IRepository<Product> productRepository,
			IRepository<Shop> shopRepository,
			IRepository<User> userRepository)
		{
			_basketRepository = basketRepository;
			_basketItemRepository = basketItemRepository;
			_positionRepository = positionRepository;
			_productRepository = productRepository;
			_shopRepository = shopRepository;
			_userRepository = userRepository;
		}

		public void FillProductRepository()
		{
			foreach (var line in File.ReadLines("../Distribution.DAL/Infrastructure/InitialDataFiles/InitialProductData.txt"))
			{
				var fields = line.Split(',');
				_productRepository.Add(new Product(fields[0], Convert.ToDecimal(fields[1])));
			}
		}

		public void FillShopRepository()
		{
			foreach (var shopTitle in File.ReadLines("../Distribution.DAL/Infrastructure/InitialDataFiles/InitialShopData.txt"))
			{
				var shop = new Shop(shopTitle);

				foreach (var product in _productRepository.GetAll())
					if (random.NextDouble() > 0.7)
						shop.Positions.Add(_positionRepository.Add(new Position(product, random.Next(20))));

				_shopRepository.Add(shop);
			}
		}

		public void FillUserRepository()
		{
			foreach (var userName in File.ReadLines("../Distribution.DAL/Infrastructure/InitialDataFiles/InitialUserData.txt"))
			{
				var desiredBasketItems = new List<BasketItem>();

				foreach (var product in _productRepository.GetAll())
					if (random.NextDouble() > 0.7)
						desiredBasketItems.Add(_basketItemRepository.Add(new BasketItem(product, random.Next(5, 20))));

				if (desiredBasketItems.Count > 0)
					_userRepository.Add(new User(
						userName,
						new List<Basket>() { _basketRepository.Add(new Basket(desiredBasketItems)) }));
			}
		}
	}
}
