using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Distribution.DAL.Entities
{
	public class Basket : Entity
	{
		[ForeignKey("User")]
		public int UserId { get; set; }
		[ForeignKey("Order")]
		public int OrderId { get; set; }
		public DateTime DateTime{ get; set; }
		public List<Position> Positions { get; set; } = new List<Position>();

		public Basket(List<Position> positions)
		{
			Positions = positions;
			DateTime = DateTime.Now;
		}
	}
}
