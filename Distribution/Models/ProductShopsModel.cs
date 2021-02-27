using System.Collections.Generic;

namespace Distribution.Models
{
	public class ProductShopsModel
	{
		public string Title { get; set; }
		public decimal Price { get; set; }
		public Dictionary<string, int> ShopProductAmounts { get; set; } = new Dictionary<string, int>();
	}
}
