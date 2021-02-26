using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
    public class Shop
    {
        public static int nextId;
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Position> Positions { get; set; }

        public Shop(string title)
        {
            Id = nextId++; 
            Title = title;
            Positions = new List<Position>();
        }
    }
}
