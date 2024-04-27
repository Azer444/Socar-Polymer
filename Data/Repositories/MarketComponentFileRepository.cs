using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MarketComponentFileRepository : Repository<MarketComponentFile>, IMarketComponentFileRepository
    {
        private readonly PolymerContext db;

        public MarketComponentFileRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async Task<List<MarketComponentFile>> GetAllByMarketComponentId(int? id)
        {
            var marketComponentFiles = await db.MarketComponentFiles
                                                        .Where(mcf => mcf.MarketComponentId == id)
                                                        .ToListAsync();
            return marketComponentFiles;
        }
    }
}
