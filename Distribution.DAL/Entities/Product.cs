namespace Distribution.DAL.Entities
{
	public class Product : Entity
	{
		public string Title { get; set; }
		public decimal Price { get; set; }

		public Product(string title, decimal price)
		{
			Title = title;
			Price = price;
		}
	}
}
