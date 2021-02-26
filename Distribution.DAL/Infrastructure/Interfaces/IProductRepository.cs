using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Infrastructure.Interfaces
{
	public interface IProductRepository
	{
		public Product GetById(int id);
		public Product GetRandom();
		public int GetProductCount();
		public Product Add(string title, decimal price);
		public List<Product> GetAllProducts();
	}
}
