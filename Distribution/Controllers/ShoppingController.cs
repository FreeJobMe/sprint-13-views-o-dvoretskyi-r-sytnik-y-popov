using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using Distribution.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.UI.Controllers
{
    public class ShoppingController : Controller
    {
        private IRepository<User> _userRepository;

        public ShoppingController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult ShoppingList()
        {
            var shoppingListOfUsers = new List<ShoppingListModel>();
            foreach (var user in _userRepository.GetAll())
            {
                var shoppingListOfUser = new ShoppingListModel() { FullName = user.FullName };
                foreach (var basket in user.Baskets)
                {
                    shoppingListOfUser.Baskets.Add(basket.BasketItems);
                }
                shoppingListOfUsers.Add(shoppingListOfUser);
            }
            return View(shoppingListOfUsers);
        }
    }
}
