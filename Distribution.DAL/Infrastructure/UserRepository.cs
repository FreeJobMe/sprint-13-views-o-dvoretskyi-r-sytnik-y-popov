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
		private IPositionRepository _positionRepository;
		private IProductRepository _productRepository;
		private IBasketRepository _basketRepository;
		private Random random = new Random();
		public UserRepository(IPositionRepository positionRepository, IProductRepository productRepository, 
							  IBasketRepository basketRepository)
        {
			_positionRepository = positionRepository;
			_productRepository = productRepository;
			_basketRepository = basketRepository;

			User.nextId = 1;

			users.AddRange(new List<User>()
			{
				new User("Roman Sytnik"),
				new User("Yurii Popov"),
				new User("Oleksandr Dvoretskyi")
			});

			foreach (var user in users)
			{
				var selectedProduct = new List<Product>();
				var desiredPositions = new List<Position>();
				for (int i = 0, iLim = random.Next(3, _productRepository.GetProductCount()); i < iLim; i++)
				{
					var product = _productRepository.GetRandom();
					if (!selectedProduct.Contains(product))
					{
						selectedProduct.Add(product);
						desiredPositions.Add(_positionRepository.Add(product, random.Next(20)));
					}
				}
				user.Baskets.Add(_basketRepository.Add(desiredPositions));
			}
		}

        public User GetById(int id) => users.First(u => u.Id == id);
		public User Add(string fullName)
		{
			var user = new User(fullName);
			users.Add(user);
			return user;
		}
	}
}
