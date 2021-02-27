using System;
using System.Collections.Generic;
using System.Text;

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
