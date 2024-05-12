using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.Contracts;

namespace StoreApp.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductController : Controller
	{
		private readonly IServiceManager _manager;

		public ProductController(IServiceManager manager)
		{
			_manager = manager;
		}

		public IActionResult Index()
		{
			var model = _manager.ProductService.GetAllProducts(false);
			return View(model);
		}
		public IActionResult create()
		{
			    ViewBag.Categories = new SelectList(_manager.CategoryService.GetAllCategories(false),
				"CategoryId", 
				"CategoryName", "1");



			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create([FromForm] ProductDtoForInsteriton product)
		{
			if (ModelState.IsValid)
			{
				_manager.ProductService.CreateProduct(product);
				return RedirectToAction("Index");
			}
			return View();
		}
		public IActionResult Update([FromRoute(Name = "id")] int id)
		{
			var model = _manager.ProductService.GetOneProduct(id, false);
			return View(model);
		}
			}
			return View();

		}
		[HttpGet]
		public IActionResult Delete([FromRoute(Name = "id")] int id)
		{
			_manager.ProductService.DeleteOneProduct(id);
			return RedirectToAction("Index");
		}
	}
}
