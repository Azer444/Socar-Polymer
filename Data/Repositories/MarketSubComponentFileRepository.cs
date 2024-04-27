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
    public class MarketSubComponentFileRepository : Repository<MarketSubComponentFile>, IMarketSubComponentFileRepository
    {
        private readonly PolymerContext db;

        public MarketSubComponentFileRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async Task<List<MarketSubComponentFile>> GetAllByMarketComponentSubComponentId(int? id)
        {
            var marketComponentSubComponentFiles = await db.MarketSubComponentFiles
                                                        .Where(scf => scf.MarketSubComponentId == id)
                                                        .ToListAsync();
            return marketComponentSubComponentFiles;
        }
    }
}
