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

        public List<Basket> Baskets { get; set; }

        public User(string fullName)
        {
            Id = nextId++;
            FullName = fullName;
            Baskets = new List<Basket>();
        }
    }
}
