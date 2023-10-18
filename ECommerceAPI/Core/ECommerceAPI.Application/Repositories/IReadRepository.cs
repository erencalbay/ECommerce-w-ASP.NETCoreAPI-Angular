using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    // the T is what entity came here. example: product, customer ..
    // In this class, we will perform operations in accordance with the SELECT operations in the database.
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        //IQueryabl
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        //if we didn't use a Task-Async the GetSingleAsync is would be like this:
        // => T GetSingle(Expression<Func<T, bool>> method);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method); 
        Task<T> GetByIdAsync(string id);

    }
}
