using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.Models
{
	public class ProductShopsModel
	{
		public string Title { get; set; }
		public decimal Price { get; set; }
		public Dictionary<string, int> ShopProductAmounts { get; set; } = new Dictionary<string, int>();
	}
}
