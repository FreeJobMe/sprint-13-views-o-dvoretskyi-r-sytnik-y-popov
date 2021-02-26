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
			Product.nextId = 1;
			products.AddRange(new List<Product>() 
			{
				new Product("Bread", 10), 
				new Product("Milk", 11),
				new Product("Cheese", 140),
				new Product("Sausage", 110),
				new Product("Potato", 7),
				new Product("Banana", 23),
				new Product("Tomato", 25),
				new Product("Candy", 75),
				new Product("Cake", 50),
				new Product("Ice Cream", 30),
				new Product("Cola", 25),
				new Product("Fanta", 20),
				new Product("Sprite", 20)
			});
		}

		public Product GetById(int id) => 
			products.First(p => p.Id == id);
	}
}
