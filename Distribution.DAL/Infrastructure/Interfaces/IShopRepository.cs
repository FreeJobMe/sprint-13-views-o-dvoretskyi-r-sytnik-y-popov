using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Infrastructure.Interfaces
{
    public interface IShopRepository
    {
        public Shop GetById(int id);
        public Shop Add(string title);
        public List<Shop> GetAllShops();
    }
}
