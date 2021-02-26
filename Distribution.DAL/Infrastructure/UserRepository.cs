using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Distribution.DAL.Infrastructure.Interfaces;

namespace Distribution.DAL.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>();

        public UserRepository()
        {
            User.nextId = 1;
            /*
            users.AddRange(new List<User>()
            {
                new User("Sytnik Roman"),
                new User("Popov Yurii"),
                new User("Dvoretskyi Oleksandr")
            });*/
        }

        public User GetById(int id) =>
            users.First(u => u.Id == id);
    }
}
