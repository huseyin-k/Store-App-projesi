using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface IProductService
	{
		IEnumerable<ProductDtoForInsteriton> GetAllProducts (bool trackChanges);
		ProductDtoForInsteriton? GetOneProduct(int id, bool trackChanges);
		void CreateProduct(ProductDtoForInsteriton product);
		void UpdateOneProduct(ProductDtoForInsteriton product);
		void DeleteOneProduct(int id);
	}
}
