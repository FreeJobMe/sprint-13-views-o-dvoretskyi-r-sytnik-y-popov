using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distribution.DAL.Infrastructure
{
    public class ShopRepository : IShopRepository
    {
        private List<Shop> shops = new List<Shop>();
        public ShopRepository()
        {
            Shop.nextId = 1;
            //shops.AddRange(new List<Shop>()
            //{
            //    new Shop("WellMart", new List<Position>()),
            //    new Shop("Silpo", new List<Position>()),
            //    new Shop("ATB", new List<Position>()),
            //    new Shop("Furshet", new List<Position>()),
            //    new Shop("Metro", new List<Position>())
            //});
        }
        public Shop GetById(int id) => 
            shops.First(s => s.Id == id);
    }
}
