namespace Distribution.DAL.Entities
{
	public class Position : Entity
	{
		public Product Product { get; set; }
		public int Amount { get; set; }

		public Position(Product product, int amount)
		{
			Product = product;
			Amount = amount;
		}
	}
}
