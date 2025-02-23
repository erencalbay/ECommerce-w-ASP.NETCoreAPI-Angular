using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using a = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Repositories
{
    public interface IMenuWriteRepository : IWriteRepository<a.Menu>
    {
    }
}
