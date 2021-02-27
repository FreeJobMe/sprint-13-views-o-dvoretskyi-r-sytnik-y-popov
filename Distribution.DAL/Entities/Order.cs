using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Order : Entity
	{
		public Basket Basket { get; set; }
		public Shop Shop { get; set; }
		public string Address { get; set; }

		public Order(Basket basket, Shop shop, string address)
		{
			Basket = basket;
			Shop = shop;
			Address = address;
		}
	}
}
