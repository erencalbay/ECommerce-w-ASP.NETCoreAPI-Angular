using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ECommerceAPI.Application.Abstractions.Services.Authentications;
using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.Repositories.CustomerRepository;
using ECommerceAPI.Application.Repositories.File;
using ECommerceAPI.Application.Repositories.InvoiceFile;
using ECommerceAPI.Application.Repositories.OrderRepository;
using ECommerceAPI.Application.Repositories.ProductImageFile;
using ECommerceAPI.Application.Repositories.ProductRepository;
using ECommerceAPI.Domain.Entities.Identity;
using ECommerceAPI.Persistence.Repositories.CustomerConcrete;
using ECommerceAPI.Persistence.Repositories.FileConcrete;
using ECommerceAPI.Persistence.Repositories.InvoiceConcrete;
using ECommerceAPI.Persistence.Repositories.OrderConcrete;
using ECommerceAPI.Persistence.Repositories.ProductConcrete;
using ECommerceAPI.Persistence.Repositories.ProductImageFileConcrete;
using ECommerceAPI.Persistence.Contexts;
using ECommerceAPI.Persistence.Services;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using ECommerceAPI.Application.Repositories.CompletedOrder;
using ECommerceAPI.Persistence.Repositories.CompletedOrder;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext <ECommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ECommerceAPIDbContext>()
            .AddDefaultTokenProviders();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();
            services.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
            services.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();
            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
            services.AddScoped<ICompletedOrderReadRepository, CompletedOrderReadRepository>();
            services.AddScoped<ICompletedOrderWriteRepository, CompletedOrderWriteRepository>();


            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IRoleService, RoleService>();

        }
    }
}