﻿using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Application.Repositories.ProductRepository;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.ProductConcrete
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}