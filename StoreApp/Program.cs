
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapAreaControllerRoute(
    name: "default",
    areaName: "MyArea", // areaName de�eri
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();