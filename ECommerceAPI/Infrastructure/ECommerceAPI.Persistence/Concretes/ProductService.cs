using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
               => new() 
               { 
                   new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Stock = 10},
                   new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 110, Stock = 20},
                   new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 120, Stock = 30},
                   new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 130, Stock = 40},
                   new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 140, Stock = 50},
               };
    }
}
