using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
	public class ProductRepository : IProductRepository
	{
		private List<Product> products = new List<Product>();

		public ProductRepository()
		{
			Product.nextId = 0;
			products.AddRange(new List<Product>() {
				//new Product("Bread", 10), 
				//new Product("Milk", 11),
				//new Product("Cheese", 140),
				//new Product("Sausage", 110),
				//new Product("Potato", 7),
				//new Product("Banana", 23),
				//new Product("Tomato", 25),
				//new Product("Candy", 75),
			});
		}

		public Product GetById(int id) => 
			products.First(p => p.Id == id);
	}
}
