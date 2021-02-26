using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Infrastructure.Interfaces
{
	public interface IPositionRepository
	{
		public Position GetById(int id);
	}
}
