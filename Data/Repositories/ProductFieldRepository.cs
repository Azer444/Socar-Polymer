using Core.Models;
using Core.Repositories;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductFieldRepository : Repository<ProductField>, IProductFieldRepository
    {
        private readonly PolymerContext db;

        public ProductFieldRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }
    }
}
