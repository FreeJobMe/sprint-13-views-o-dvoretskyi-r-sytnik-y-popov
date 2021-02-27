using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class BasketItem : Entity
	{
		public Product Product { get; set; }
		public int Amount { get; set; }

		public BasketItem(Product product, int amount)
		{
			Product = product;
			Amount = amount;
		}
	}
}
