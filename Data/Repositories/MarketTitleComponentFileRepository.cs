using Core.Models;
using Core.Repositories;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MarketTitleComponentFileRepository : Repository<MarketTitleComponentFile>, IMarketTitleComponentFileRepository
    {
        private readonly PolymerContext db;

        public MarketTitleComponentFileRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }
    }
}
