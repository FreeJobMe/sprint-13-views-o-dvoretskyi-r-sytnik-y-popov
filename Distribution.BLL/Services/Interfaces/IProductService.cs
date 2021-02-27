using Distribution.DAL.Entities;

namespace Distribution.BLL.Services.Interfaces
{
	public interface IProductService
	{
		public int GetTotalAmountInAllShops(Product product);
	}
}
