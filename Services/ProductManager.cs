﻿using Entities.Models;
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

		public IEnumerable<Product> GetAllProducts(bool trackChanges)
		{
			return _manager.Product.GetAllProducts(trackChanges);
		}

		public Product? GetOneProduct(int id, bool trackChanges)
		{
			var Product = _manager.Product.GetOneProduct(id, trackChanges);
			if (Product is null)
				throw new Exception("Product Not found!");
			return Product;	
		}
	}
}
