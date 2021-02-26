using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Position
	{
		public static int nextId;
		public int Id { get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; }

		public Position(int shopId, Product product, int amount)
		{
			Id = nextId++;
			Product = product;
			Amount = amount;
		}
	}
}
