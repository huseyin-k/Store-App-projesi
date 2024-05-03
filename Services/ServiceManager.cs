using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class ServiceManager : IServiceManager
	{
		private readonly IProductService _productService;
		private readonly ICategoryServices _categoryService;

		public ServiceManager(IProductService productService, ICategoryServices categoryService)
		{
			_productService = productService;
			_categoryService = categoryService;
		}

		public IProductService ProductService => _productService;

		public ICategoryServices CategoryService => _categoryService;
	}
}
