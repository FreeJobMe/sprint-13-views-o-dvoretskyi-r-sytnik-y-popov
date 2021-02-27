using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

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
