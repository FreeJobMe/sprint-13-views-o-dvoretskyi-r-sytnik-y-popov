using Distribution.BLL.Services.Interfaces;
using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.BLL.Services
{
	public class ProductService : IProductService
	{
		private IPositionRepository _positionRepository;
		private IProductRepository _productRepository;
		private IShopRepository _shopRepository;

		public ProductService(IPositionRepository positionRepository, IProductRepository productRepository, IShopRepository shopRepository)
		{
			_positionRepository = positionRepository;
			_productRepository = productRepository;
			_shopRepository = shopRepository;
		}

		public int GetTotalAmountInAllShops(Product product)
		{
			return 0;
		}
	}
}
