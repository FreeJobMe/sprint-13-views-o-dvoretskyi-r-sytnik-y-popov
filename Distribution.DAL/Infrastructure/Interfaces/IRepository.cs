using Distribution.DAL.Entities;
using System.Collections.Generic;

namespace Distribution.DAL.Infrastructure.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class, IEntity
	{
		public TEntity Add(TEntity entity);

		public List<TEntity> GetAll();

		public TEntity GetRandom();

		public int GetCount();

	}
}
