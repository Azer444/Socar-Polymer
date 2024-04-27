using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        private readonly PolymerContext db;

        public ProductCategoryRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }

        public async override Task<List<ProductCategory>> GetAllAsync()
        {
            var productCategories = await db.ProductCategories
                                                         .Include(c => c.ProductTitleCategory)
                                                         .Include(c => c.ProductCategoryProperties)
                                                         .Include(c => c.Products)
                                                         .ThenInclude(c => c.ProductFields)
                                                         .ToListAsync();
            return productCategories;
        }

        public async override Task<ProductCategory> GetAsync(int? id)
        {
            var productCategory = await db.ProductCategories
                                                         .Include(c => c.ProductTitleCategory)
                                                         .Include(c => c.ProductCategoryProperties)
                                                         .Include(c => c.Products)
                                                         .ThenInclude(c => c.ProductFields)
                                                         .FirstOrDefaultAsync(c => c.Id == id);
            return productCategory;
        }
    }
}
