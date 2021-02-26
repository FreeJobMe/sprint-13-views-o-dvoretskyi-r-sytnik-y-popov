using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Product
	{
		public static int nextId;
		public int Id { get; set; }
		public string Title { get; set; }
		public decimal Price { get; set; }

		public Product(string title, decimal price)
		{
			Id = nextId++;
			Title = title;
			Price = price;
		}
	}
}
