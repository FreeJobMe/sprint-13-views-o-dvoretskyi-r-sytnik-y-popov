using Distribution.DAL.Entities;
using System.Collections.Generic;

namespace Distribution.Models
{
	public class ShopModel
	{
		public string Title { get; set; }
		public List<Position> Positions { get; set; } = new List<Position>();
	}
}
