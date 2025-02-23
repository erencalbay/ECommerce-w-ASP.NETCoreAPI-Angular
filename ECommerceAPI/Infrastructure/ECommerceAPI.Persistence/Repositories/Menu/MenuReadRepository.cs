using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a= ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistence.Repositories.Menu
{
    public class MenuReadRepository : ReadRepository<a.Menu>, IMenuReadRepository
    {
        public MenuReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
