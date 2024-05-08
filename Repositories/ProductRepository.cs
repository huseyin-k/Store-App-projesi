using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class ProductRepository : RepositoryBase<ProductDtoForInsteriton>, IProductRepository
	{
		public ProductRepository(RepositoryContext context) : base(context)
		{
		}

		public void CreateOneProduct(ProductDtoForInsteriton product)
		{
			throw new NotImplementedException();
		}

		public void CreateProduct(ProductDtoForInsteriton product) => Create(product);

		public void DeleteOneProduct(ProductDtoForInsteriton product) => Remowe(product);


		public IQueryable<ProductDtoForInsteriton> GetAllProducts(bool trackChanges) => FindAll(trackChanges); 

		public ProductDtoForInsteriton? GetOneProduct(int id, bool trackChanges)
		{
			return FindByCondition(p=> p.ProductId.Equals(id) ,trackChanges);
		}
	
	}
} 
