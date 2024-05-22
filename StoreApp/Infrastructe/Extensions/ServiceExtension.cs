﻿using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;
using Services;
using Entities.Models;
using StoreApp.Models;

namespace StoreApp.Infrastructe.Extensions
{
	public static class ServiceExtension
	{
		public static void ConfigureDbContext(this IServiceCollection services,
			IConfiguration configuration)
		{

			services.AddDbContext<RepositoryContext>(options =>
			{
				options.UseSqlite(configuration.GetConnectionString("sqlconnection"),
					b => b.MigrationsAssembly("StoreApp"));
			});


		}

		public static void ConfigureSession(this IServiceCollection services)
		{
			services.AddDistributedMemoryCache();
			services.AddSession(options =>
			{
				options.Cookie.Name = "StoreApp.Session";
				options.IdleTimeout = TimeSpan.FromMinutes(10);
			});
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddScoped<Cart>(c => SessionCart.GetCart(c));
		}

		public static void   ConfigureRepositoryResgistration(this IServiceCollection services) 
		{
			services.AddScoped<IRepositoryManager, RepositoryManager>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IOrderRepository, OrderRepository>();
		}
		public static void ConfigureServiceResgistration(this IServiceCollection services)
		{
			services.AddScoped<IServiceManager, ServiceManager>();
			services.AddScoped<IProductService, ProductManager>();
			services.AddScoped<ICategoryServices, CategoryManager>();
			services.AddScoped<IOrderService, OrderManager>();
		}

		public static void ConfigureRouting(this IServiceCollection services) 
		{
			services.AddRouting(options =>
			{
				options.LowercaseUrls = true;
				options.AppendTrailingSlash = false;
			});
		}
	}
}
