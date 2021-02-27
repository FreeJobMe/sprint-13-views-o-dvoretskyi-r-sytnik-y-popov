using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class BasketItem : Entity
	{
		[ForeignKey("Basket")]
		public int BasketId { get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; }

		public BasketItem(Product product, int amount)
		{
			Product = product;
			Amount = amount;
		}
	}
}
