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
    public class MarketTitleComponentRepository : Repository<MarketTitleComponent>, IMarketTitleComponentRepository
    {
        private readonly PolymerContext db;

        public MarketTitleComponentRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }

        public async override Task<List<MarketTitleComponent>> GetAllAsync()
        {
            var marketTitleComponents = await db.MarketTitleComponents
                                                            .Include(mtc => mtc.Location)
                                                            .Include(mtc => mtc.NavTitleComponent)
                                                            .Include(mtc => mtc.MarketTitleComponentFiles)
                                                            .Include(mtc => mtc.MarketComponents)
                                                            .ThenInclude(mc => mc.MarketComponentFiles)
                                                            .Include(mtc => mtc.MarketComponents)
                                                            .ThenInclude(mc => mc.MarketSubComponents)
                                                            .ThenInclude(msc => msc.MarketSubComponentFiles)
                                                            .Include(mtc => mtc.MarketComponents)
                                                            .ThenInclude(mc => mc.MarketSubComponents)
                                                            .ToListAsync();
            return marketTitleComponents;
        }

        public async Task<List<MarketTitleComponent>> GetAllByLocationAsync(string location)
        {
            var marketTitleComponents = await db.MarketTitleComponents
                                                            .Where(mc => mc.Location.Name.ToLower() == location.ToLower())
                                                            .ToListAsync();
            return marketTitleComponents;
        }

        public async override Task<MarketTitleComponent> GetAsync(int? id)
        {
            var marketTitleComponent = await db.MarketTitleComponents
                                                            .Include(mtc => mtc.Location)
                                                            .Include(mtc => mtc.NavTitleComponent)
                                                            .Include(mtc => mtc.MarketTitleComponentFiles)
                                                            .Include(mtc => mtc.MarketComponents)
                                                            .ThenInclude(mc => mc.MarketComponentFiles)
                                                            .Include(mtc => mtc.MarketComponents)
                                                            .ThenInclude(mc => mc.MarketSubComponents)
                                                            .ThenInclude(msc => msc.MarketSubComponentFiles)
                                                            .Include(mtc => mtc.MarketComponents)
                                                            .ThenInclude(mc => mc.MarketSubComponents)
                                                            .FirstOrDefaultAsync(mtc => mtc.Id == id);
            return marketTitleComponent;
        }

        public async Task<MarketTitleComponent> GetBySlugAsync(string slug)
        {
            var marketTitleComponent = await db.MarketTitleComponents
                                                                   .Include(mtc => mtc.Location)
                                                                   .Include(mtc => mtc.NavTitleComponent)
                                                                   .Include(mtc => mtc.MarketComponents)
                                                                   .FirstOrDefaultAsync(c => c.Slug == slug);
            return marketTitleComponent;
        }

        public async Task RegulateSlugAsync(MarketTitleComponent marketTitleComponent)
        {
            if (await db.MarketTitleComponents.AnyAsync(p => p.Id != marketTitleComponent.Id && p.Slug == marketTitleComponent.Slug))
                marketTitleComponent.Slug = marketTitleComponent.Slug + "-" + marketTitleComponent.Id;

            db.MarketTitleComponents.Attach(marketTitleComponent);
            db.Entry(marketTitleComponent).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
