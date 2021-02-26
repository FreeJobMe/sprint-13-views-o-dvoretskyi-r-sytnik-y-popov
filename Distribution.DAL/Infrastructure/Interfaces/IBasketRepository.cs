using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Infrastructure.Interfaces
{
    public interface IBasketRepository
    {
        public Basket GetById(int id);
        Basket Add(List<Position> positions);
    }
}
