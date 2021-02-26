using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
	public class OrderRepository : IOrderRepository
	{
		private List<Order> orders = new List<Order>();

		public OrderRepository()
		{
			Order.nextId = 1;
			orders.AddRange(new List<Order>() {
				//new Order(0, 0, "Khreshatik, 32"),
				//new Order(1, 1, "Bandery, 126"),
				//new Order(2, 2, "Pobedy, 11")
			});
		}

		public Order GetById(int id) =>
			orders.First(p => p.Id == id);
	}
}
