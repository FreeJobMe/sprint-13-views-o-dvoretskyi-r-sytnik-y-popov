using Distribution.DAL.Infrastructure.Interfaces;
using Distribution.UI.Models;
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
        private IUserRepository _userRepository;

        public ShoppingController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult ShoppingList()
        {
            var shoppingListOfUsers = new List<ShoppingListModel>();
            foreach (var user in _userRepository.GetAllUsers())
            {
                var shoppingListOfUser = new ShoppingListModel() { FullName = user.FullName };
                foreach (var basket in user.Baskets)
                {
                    var positions = new Dictionary<string, int>();
                    foreach (var position in basket.Positions)
                    {
                        positions.Add(position.Product.Title, position.Amount);
                    }
                    shoppingListOfUser.BasketPositions.Add(positions);
                }
                shoppingListOfUsers.Add(shoppingListOfUser);
            }
            return View(shoppingListOfUsers);
        }
    }
}
