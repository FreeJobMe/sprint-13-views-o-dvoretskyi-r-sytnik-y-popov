using Distribution.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Distribution.BLL.Services.Interfaces
{
	public interface IProductService
	{
		public int GetTotalAmountInAllShops(Product product);
	}
}
