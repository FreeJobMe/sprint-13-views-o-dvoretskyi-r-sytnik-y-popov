using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.Models
{
    public class ShoppingListModel
    {
        public string FullName { get; set; }
        public List<List<BasketItem>> Baskets { get; set; } = new List<List<BasketItem>>();
    }
}
