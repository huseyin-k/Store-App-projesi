using Microsoft.AspNetCore.Mvc;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductContoller : Controller
    {
        public IEnumerable <Product> Index()
        {
            return new List<Product>();
            {
            };
        }
    }
}
