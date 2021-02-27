using Distribution.DAL.Infrastructure.Interfaces;
using Distribution.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Distribution.UI.Controllers
{
    public class ShopController : Controller
    {
        private IPositionRepository _positionRepository;
        private IProductRepository _productRepository;
        private IShopRepository _shopRepository;

        public ShopController(IPositionRepository positionRepository, IProductRepository productRepository, IShopRepository shopRepository)
        {
            _positionRepository = positionRepository;
            _productRepository = productRepository;
            _shopRepository = shopRepository;
        }
        public IActionResult Info()
        {
            var shopModels = new List<ShopModel>();
            foreach (var shop in _shopRepository.GetAllShops())
            {
                var shopModel = new ShopModel()
                {
                    Title = shop.Title,
                    Positions = shop.Positions,
                    
                };
               foreach(var position in shop.Positions)
                {
                    
                    var amount = shop.Positions.Count;
                    if (amount>0)
                    {
                        shopModel.ProductAmounts.Add(position.Product.Title, position.Amount);
                    }
                }
               if(shopModel.ProductAmounts.Count>0)
                {
                    shopModels.Add(shopModel);
                }
            }
            return View(shopModels);
        }
    }
}
