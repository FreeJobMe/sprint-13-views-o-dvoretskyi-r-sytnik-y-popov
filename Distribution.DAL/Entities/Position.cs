using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Position : Entity
	{
		[ForeignKey("Shop")]
		public int ShopId { get; set; }
		public Product Product { get; set; }
		public int Amount { get; set; }

		public Position(Product product, int amount)
		{
			Product = product;
			Amount = amount;
		}
	}
}
