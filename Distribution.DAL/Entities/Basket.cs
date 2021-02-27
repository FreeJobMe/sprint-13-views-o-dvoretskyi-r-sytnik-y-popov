using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Basket : Entity
	{
		public DateTime DateTime{ get; set; }
		public List<Position> Positions { get; set; } = new List<Position>();

		public Basket(List<Position> positions)
		{
			Positions = positions;
			DateTime = DateTime.Now;
		}
	}
}
