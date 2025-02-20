using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Repositories.CompletedOrder
{
    public interface ICompletedOrderWriteRepository : IWriteRepository<c.CompletedOrder>
    {
    }
}
