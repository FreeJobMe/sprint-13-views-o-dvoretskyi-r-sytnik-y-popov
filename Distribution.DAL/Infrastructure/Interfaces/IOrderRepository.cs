using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Infrastructure.Interfaces
{
	public interface IOrderRepository
	{
		public Order GetById(int id);
	}
}
