using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
	public class ProductRepository
	{
		private List<Product> products = new List<Product>();

		public ProductRepository()
		{
			Product.nextId = 0;
			products.AddRange(new List<Product>() {
				new Product("Bread", 10), 
				new Product("Milk", 11)});
		}

		public Product GetById(int id) => 
			products.First(p => p.Id == id);
	}
}
