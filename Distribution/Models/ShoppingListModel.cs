using Distribution.DAL.Entities;
using System.Collections.Generic;

namespace Distribution.Models
{
    public class ShoppingListModel
    {
        public string FullName { get; set; }
        public List<List<BasketItem>> Baskets { get; set; } = new List<List<BasketItem>>();
    }
}
