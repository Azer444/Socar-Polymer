using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductCategoryPropertyRepository : Repository<ProductCategoryProperty>, IProductCategoryPropertyRepository
    {
        private readonly PolymerContext db;

        public ProductCategoryPropertyRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }

        public async Task<List<ProductCategoryProperty>> GetAllByCategoryAsync(int? id)
        {
            var productCategoryProperties = await db.ProductCategoryProperties
                                                                     .Where(p => p.ProductCategoryId == id)
                                                                     .ToListAsync();
            return productCategoryProperties;
        }
    }
}
