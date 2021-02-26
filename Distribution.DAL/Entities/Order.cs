using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Order
	{
		public static int nextId;
		public int Id { get; set; }
		public Basket Basket { get; set; }
		public Shop Shop { get; set; }
		public string Address { get; set; }

		public Order(Basket basket, Shop shop, string address)
		{
			Id = nextId++;
			Basket = basket;
			Shop = shop;
			Address = address;
		}
	}
}
