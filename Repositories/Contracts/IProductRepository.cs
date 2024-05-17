using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	public interface IProductRepository : IRepositoryBase<Product>
	{
		IQueryable<Product> GetAllProducts(bool trackChanges);
		Product? GetOneProduct(int id, bool trackChanges);

		void CreateOneProduct(Product product);
		void DeleteOneProduct(Product product);
		void Create(Product product);
		void DeleteOneProduct(ProductDtoForInsertion product);
		void UpdateOneProduct(Product entity);
	}
}
