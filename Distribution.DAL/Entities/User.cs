using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
    public class User
    {
        public static int nextId;

        public int Id { get; set; }

        public string FullName { get; set; }

        private List<Basket> baskets = new List<Basket>();

        public User(string fullName)
        {
            Id = nextId++;
            FullName = fullName;
        }
    }
}
