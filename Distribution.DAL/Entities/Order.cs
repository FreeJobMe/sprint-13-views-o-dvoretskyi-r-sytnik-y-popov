using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Order : Entity
	{
		public Shop Shop { get; set; }
		public string Address { get; set; }
		public List<Position> Baskets { get; set; }

		public Order(Shop shop, string address, List<Position> baskets)
		{
			Shop = shop;
			Address = address;
			Baskets = baskets;
		}
	}
}
