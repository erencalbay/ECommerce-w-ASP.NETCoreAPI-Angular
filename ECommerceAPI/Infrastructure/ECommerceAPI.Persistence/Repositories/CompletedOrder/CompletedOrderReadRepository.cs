﻿using ECommerceAPI.Application.Repositories.CompletedOrder;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistence.Repositories.CompletedOrder
{
    public class CompletedOrderReadRepository : ReadRepository<c.CompletedOrder>, ICompletedOrderReadRepository
    {
        public CompletedOrderReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
