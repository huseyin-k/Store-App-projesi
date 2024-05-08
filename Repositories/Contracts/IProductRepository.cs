using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	public interface IProductRepository : IRepositoryBase<ProductDtoForInsteriton>
	{
		IQueryable<ProductDtoForInsteriton> GetAllProducts(bool trackChanges);
		ProductDtoForInsteriton? GetOneProduct(int id, bool trackChanges);

		void CreateOneProduct(ProductDtoForInsteriton product);
		void DeleteOneProduct(ProductDtoForInsteriton product);
	}
}
