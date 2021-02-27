using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.DAL.Entities
{
	public abstract class Entity : IEntity
	{
		public int Id { get; set; }
		public void SetId(int id) => Id = id;
	}
}
