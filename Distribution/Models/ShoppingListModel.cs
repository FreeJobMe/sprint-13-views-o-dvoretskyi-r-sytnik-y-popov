using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.Models
{
    public class ShoppingListModel
    {
        public string FullName { get; set; }
        public List<Dictionary<string, int>> BasketPositions { get; set; } = new List<Dictionary<string, int>>();
    }
}
