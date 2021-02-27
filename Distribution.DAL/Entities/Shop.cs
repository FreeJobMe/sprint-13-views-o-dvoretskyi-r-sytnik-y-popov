using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
    public class Shop : Entity
    {
        public string Title { get; set; }
        public List<Position> Positions { get; set; } = new List<Position>();

        public Shop(string title)
        {
            Title = title;
         }
    }
}
