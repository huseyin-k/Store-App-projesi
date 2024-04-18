
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection");
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapAreaControllerRoute(
    name: "default",
    areaName: "MyArea", // areaName deðeri
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();