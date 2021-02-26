using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
	public class PositionRepository : IPositionRepository
	{
		private List<Position> positions = new List<Position>();

		public PositionRepository()
		{
			Position.nextId = 1;
			positions.AddRange(new List<Position>() {
				//new Position(2, 1, 10),
				//new Position(0, 2, 10),
				//new Position(1, 0, 20)
			});
		}

		public Position GetById(int id) =>
			positions.First(p => p.Id == id);

		public Position Add(Product product, int amount)
		{
			var position = new Position(product, amount);
			positions.Add(position);
			return position;
		}
	}
}
