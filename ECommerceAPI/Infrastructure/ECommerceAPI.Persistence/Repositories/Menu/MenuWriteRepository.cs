using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a = ECommerceAPI.Domain.Entities;


namespace ECommerceAPI.Persistence.Repositories.Menu
{
    public class MenuWriteRepository : WriteRepository<a.Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
