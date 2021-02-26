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

        public List<Position> positions  = new List<Position>();
        public Basket(List<Position> postions)
        {
            Id = nextId++;
            postions = this.positions;
            DateTime = DateTime.Now;
        }
    }
}
