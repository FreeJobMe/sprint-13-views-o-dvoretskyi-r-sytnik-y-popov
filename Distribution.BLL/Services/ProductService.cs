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
		private IRepository<Position> _positionRepository;
		private IRepository<Product> _productRepository;
		private IRepository<Shop> _shopRepository;

		public ProductService(
			IRepository<Position> positionRepository,
			IRepository<Product> productRepository,
			IRepository<Shop> shopRepository)
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
