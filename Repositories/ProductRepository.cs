﻿using Entities.Dtos;
using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class ProductRepository : RepositoryBase<Product>, IProductRepository
	{
		public ProductRepository(RepositoryContext context) : base(context)
		{
		}

		

		public void CreateOneProduct(Product product)
		{
			throw new NotImplementedException();
		}

		

		public void CreateProduct(Product product) => Create(product);

		public void DeleteOneProduct(Product product) => Remowe(product);

		public void DeleteOneProduct(ProductDtoForInsertion product)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges); 

		public Product? GetOneProduct(int id, bool trackChanges)
		{
			return FindByCondition(p=> p.ProductId.Equals(id) ,trackChanges);
		}

		public void UpdateOneProduct(Product entity) => Update(entity);
		
	}
} 
