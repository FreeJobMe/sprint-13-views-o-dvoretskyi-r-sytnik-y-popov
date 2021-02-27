using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
    public class Basket : Entity
    {
        public DateTime DateTime { get; set; }
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();

        public Basket(List<BasketItem> basketItems)
        {
            BasketItems = basketItems;
            DateTime = DateTime.Now;
        }
    }
}
