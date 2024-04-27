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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly PolymerContext db;

        public ProductRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }

        public async override Task<Product> GetAsync(int? id)
        {
            var product = await db.Products
                                            .Include(p => p.ProductCategory)
                                            .ThenInclude(p => p.ProductTitleCategory)
                                            .Include(p => p.ProductCategory)
                                            .ThenInclude(c => c.ProductCategoryProperties)
                                            .Include(p => p.ProductFields)
                                            .Include(p => p.ProductBrochures)
                                            .FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }
    }
}
