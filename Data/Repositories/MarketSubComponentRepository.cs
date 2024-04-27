using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MarketSubComponentRepository : Repository<MarketSubComponent>, IMarketSubComponentRepository
    {
        private readonly PolymerContext db;

        public MarketSubComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async override Task<List<MarketSubComponent>> GetAllAsync()
        {
            var marketSubComponents = await db.MarketSubComponents
                                                            .Include(mtc => mtc.MarketComponent)
                                                            .Include(mtc => mtc.MarketSubComponentFiles)
                                                            .ToListAsync();
            return marketSubComponents;
        }

        public async override Task<MarketSubComponent> GetAsync(int? id)
        {
            var marketSubComponent = await db.MarketSubComponents
                                                            .Include(mtc => mtc.MarketComponent)
                                                            .Include(mtc => mtc.MarketSubComponentFiles)
                                                            .FirstOrDefaultAsync(mtc => mtc.Id == id);
            return marketSubComponent;
        }

        public async Task<MarketSubComponent> GetBySlugAsync(string slug)
        {
            var marketSubComponent = await db.MarketSubComponents
                                                               .Include(c => c.MarketComponent)
                                                               .ThenInclude(c => c.MarketTitleComponent)
                                                               .Include(mtc => mtc.MarketSubComponentFiles)
                                                               .FirstOrDefaultAsync(sc => sc.Slug == slug);
            return marketSubComponent;
        }

        public async Task RegulateSlugAsync(MarketSubComponent marketSubComponent)
        {
            if (await db.MarketSubComponents.AnyAsync(p => p.Id != marketSubComponent.Id && p.Slug == marketSubComponent.Slug))
                marketSubComponent.Slug = marketSubComponent.Slug + "-" + marketSubComponent.Id;

            db.MarketSubComponents.Attach(marketSubComponent);
            db.Entry(marketSubComponent).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
