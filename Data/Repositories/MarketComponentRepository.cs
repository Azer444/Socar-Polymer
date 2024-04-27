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
    public class MarketComponentRepository : Repository<MarketComponent>, IMarketComponentRepository
    {
        private readonly PolymerContext db;

        public MarketComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async override Task<List<MarketComponent>> GetAllAsync()
        {
            var marketComponents = await db.MarketComponents
                                                            .Include(mtc => mtc.MarketTitleComponent)
                                                            .Include(mtc => mtc.MarketSubComponents)
                                                            .Include(mtc => mtc.MarketComponentFiles)
                                                            .ToListAsync();
            return marketComponents;
        }

        public async override Task<MarketComponent> GetAsync(int? id)
        {
            var marketComponent = await db.MarketComponents
                                                            .Include(mtc => mtc.MarketTitleComponent)
                                                            .Include(mtc => mtc.MarketSubComponents)
                                                            .Include(mtc => mtc.MarketComponentFiles)
                                                            .FirstOrDefaultAsync(mtc => mtc.Id == id);
            return marketComponent;
        }

        public async Task<MarketComponent> GetBySlugAsync(string slug)
        {
            var marketComponent = await db.MarketComponents
                                                        .Include(c => c.MarketTitleComponent)
                                                        .Include(mtc => mtc.MarketComponentFiles)
                                                        .FirstOrDefaultAsync(c => c.Slug == slug);
            return marketComponent;
        }

        public async Task RegulateSlugAsync(MarketComponent marketComponent)
        {
            if (await db.MarketComponents.AnyAsync(p => p.Id != marketComponent.Id && p.Slug == marketComponent.Slug))
                marketComponent.Slug = marketComponent.Slug + "-" + marketComponent.Id;

            db.MarketComponents.Attach(marketComponent);
            db.Entry(marketComponent).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
