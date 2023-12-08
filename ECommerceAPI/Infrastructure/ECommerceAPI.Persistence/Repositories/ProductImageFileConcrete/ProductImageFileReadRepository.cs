using ECommerceAPI.Application.Repositories.ProductImageFile;
using ECommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories.ProductImageFileConcrete
{
    public class ProductImageFileReadRepository : ReadRepository<Domain.Entities.ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
