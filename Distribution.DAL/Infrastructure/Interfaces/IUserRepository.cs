using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        public User GetById(int id);
    }
}
