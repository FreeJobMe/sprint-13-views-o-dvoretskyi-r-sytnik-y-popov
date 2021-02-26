using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
    public class Basket
    {
        public static int nextId;

        public int Id { get; set; }
        
        public DateTime DateTime{ get; set; }

        public List<Position> Positions { get; set; }

        public Basket(List<Position> positions)
        {
            Id = nextId++; 
            Positions = positions;
            DateTime = DateTime.Now;
        }
    }
}
