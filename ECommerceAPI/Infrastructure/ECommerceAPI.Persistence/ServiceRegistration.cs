using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Application.Repositories.CustomerRepository;
using ECommerceAPI.Application.Repositories.File;
using ECommerceAPI.Application.Repositories.InvoiceFile;
using ECommerceAPI.Application.Repositories.OrderRepository;
using ECommerceAPI.Application.Repositories.ProductImageFile;
using ECommerceAPI.Application.Repositories.ProductRepository;
using ECommerceAPI.Persistence.Contexts;
using ECommerceAPI.Persistence.Repositories.CustomerConcrete;
using ECommerceAPI.Persistence.Repositories.FileConcrete;
using ECommerceAPI.Persistence.Repositories.InvoiceConcrete;
using ECommerceAPI.Persistence.Repositories.OrderConcrete;
using ECommerceAPI.Persistence.Repositories.ProductConcrete;
using ECommerceAPI.Persistence.Repositories.ProductImageFileConcrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Singleton);
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();

        }
    }
}
