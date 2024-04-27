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
    public class ProductTitleCategoryRepository : Repository<ProductTitleCategory>, IProductTitleCategoryRepository
    {
        private readonly PolymerContext db;

        public ProductTitleCategoryRepository(PolymerContext  db)
            :base(db)
        {
            this.db = db;
        }

        public async override Task<List<ProductTitleCategory>> GetAllAsync()
        {
            var productTitleCategories = await db.ProductTitleCategories
                                                                .Include(c => c.ProductCategories)
                                                                .ThenInclude(c=> c.ProductCategoryProperties)
                                                                .Include(c=> c.ProductCategories)
                                                                .ThenInclude(c=> c.Products)
                                                                .ThenInclude(c=>c.ProductFields)
                                                                .ToListAsync();
            return productTitleCategories;
        }

        public async override Task<ProductTitleCategory> GetAsync(int? id)
        {
            var productTitleCategory = await db.ProductTitleCategories
                                                                .Include(c => c.ProductCategories)
                                                                .ThenInclude(c => c.ProductCategoryProperties)
                                                                .Include(c => c.ProductCategories)
                                                                .ThenInclude(c => c.Products)
                                                                .ThenInclude(c => c.ProductFields)
                                                                .FirstOrDefaultAsync(c => c.Id == id);
            return productTitleCategory;
        }
    }
}
