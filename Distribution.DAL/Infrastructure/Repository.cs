using Distribution.DAL.Entities;
using Distribution.DAL.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace Distribution.DAL.Infrastructure
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
	{
		private List<TEntity> entities;
		private static int nextId;
		private Random random = new Random();

		public Repository()
		{
			entities = new List<TEntity>();
			nextId = 1;
		}

		public TEntity Add(TEntity entity)
		{
			entity.SetId(nextId++);
			entities.Add(entity);
			return entity;
		}

		public List<TEntity> GetAll() => entities;

		public TEntity GetRandom() => entities[random.Next(entities.Count - 1)];

		public int GetCount() => entities.Count;

	}
}
