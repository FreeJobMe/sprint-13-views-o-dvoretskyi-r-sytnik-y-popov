using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Distribution.DAL.Entities
{

    public class Basket : Entity
    {
       
		[ForeignKey("User")]
		public int UserId { get; set; }
		[ForeignKey("Order")]
		public int OrderId { get; set; }
		public DateTime DateTime { get; set; }
    public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();


        public Basket(List<BasketItem> basketItems)
        {
            BasketItems = basketItems;
            DateTime = DateTime.Now;
        }
    }
}
