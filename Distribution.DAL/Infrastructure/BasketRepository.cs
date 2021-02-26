using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distribution.DAL.Infrastructure
{
    class BasketRepository : IBasketRepository
    {
        private List<Basket> baskets = new List<Basket>();

        public BasketRepository()
        {
            Basket.nextId = 1;
            /*
            baskets.AddRange(new List<Basket>()
            {

            });*/
        }
        public Basket GetById(int id) =>
           baskets.First(u => u.Id == id);
        public Basket Add(List<Position> positions)
        {
            var basket = new Basket(positions);
            baskets.Add(basket);
            return basket;
        }
    }
}
