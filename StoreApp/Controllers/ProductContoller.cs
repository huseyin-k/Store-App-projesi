
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {
        public IEnumerable<Product> Index()
        {
            var context = new RepositoryContext(
                new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlite("Data Source = C:\\Users\\User\\Desktop\\MVC1\\Store\\StoreApp\\ProductDb.db")
                .Options);

            return context.Products;
        }
    }
}   

