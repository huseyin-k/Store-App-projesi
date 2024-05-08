using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class ProductManager : IProductService
	{
		private readonly	IRepositoryManager _manager;

		public ProductManager(IRepositoryManager manager)
		{
			_manager = manager;
		}

		public void CreateProduct(ProductDtoForInsteriton product)
		{
			_manager.Product.Create(product);
			_manager.Save();
		}

		public void DeleteOneProduct(int id)
		{
			ProductDtoForInsteriton	 product = GetOneProduct(id, false);
			if(product is not null)
			{
				_manager.Product.DeleteOneProduct(product);
				_manager.Save();
			}
		}

		public IEnumerable<ProductDtoForInsteriton> GetAllProducts(bool trackChanges)
		{
			return _manager.Product.GetAllProducts(trackChanges);
		}

		public ProductDtoForInsteriton? GetOneProduct(int id, bool trackChanges)
		{
			var Product = _manager.Product.GetOneProduct(id, trackChanges);
			if (Product is null)
				throw new Exception("Product Not found!");
			return Product;	
		}

		public void UpdateOneProduct(ProductDtoForInsteriton product)
		{
			var entity =_manager.Product.GetOneProduct(product.ProductId, true);
			entity.ProductName = product.ProductName;
			entity.Price = product.Price;
			_manager.Save();
		}
	}
}
