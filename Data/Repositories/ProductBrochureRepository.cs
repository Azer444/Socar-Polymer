using Core.Models;
using Core.Repositories;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ProductBrochureRepository : Repository<ProductBrochure>, IProductBrochureRepository
    {
        public ProductBrochureRepository(PolymerContext db)
            :base(db)
        {

        }
    }
}
