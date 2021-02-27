using System.Collections.Generic;

namespace Distribution.DAL.Entities
{
    public class User : Entity
    {
        public string FullName { get; set; }
        public List<Basket> Baskets { get; set; }

		public User(string fullName, List<Basket> baskets)
		{
			FullName = fullName;
			Baskets = baskets;
		}
	}
}
