using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
    public class ShopRepository : IShopRepository
    {
        private List<Shop> shops = new List<Shop>();
		private IPositionRepository _positionRepository;
		private IProductRepository _productRepository;
		private Random random = new Random();
		public ShopRepository(IPositionRepository positionRepository, IProductRepository productRepository)
        {
			_positionRepository = positionRepository;
			_productRepository = productRepository;

			Shop.nextId = 1;

			var newShops =	new List<Shop>()
			{
				new Shop("WellMart"),
				new Shop("Silpo"),
				new Shop("ATB"),
				new Shop("Furshet"),
				new Shop("Metro")
			};

			foreach (var newShop in newShops)
			{
				var selectedProduct = new List<Product>();
				for (int i = 0, iLim = random.Next(3, _productRepository.GetProductCount()); i < iLim; i++)
				{
					var product = _productRepository.GetRandom();
					if (!selectedProduct.Contains(product))
					{
						selectedProduct.Add(product);
						newShop.Positions.Add(_positionRepository.Add(product, random.Next(20)));
					}
				}
			}
			shops.AddRange(newShops);
		}
        public Shop GetById(int id) => 
            shops.First(s => s.Id == id);
		public Shop Add(string title)
        {
			var shop = new Shop(title);
			shops.Add(shop);
			return shop;
        }
    }
}
