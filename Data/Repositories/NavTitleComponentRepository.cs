using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class NavTitleComponentRepository : Repository<NavTitleComponent>, INavTitleComponentRepository
    {
        private readonly PolymerContext db;

        public NavTitleComponentRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }

        public async override Task<NavTitleComponent> GetAsync(int? id)
        {
            var navTitleComponent = await db.NavTitleComponents
                                                                .Include(c => c.MarketTitleComponents)
                                                                .ThenInclude(c => c.MarketComponents)
                                                                .ThenInclude(c => c.MarketSubComponents)
                                                                .Include(c => c.MarketTitleComponents)
                                                                .ThenInclude(c => c.Location)
                                                                .Include(c => c.CertificateComponents)
                                                                .Include(c => c.NavComponents)
                                                                .FirstOrDefaultAsync(c => c.Id == id);
            return navTitleComponent;
        }

        public async override Task<List<NavTitleComponent>> GetAllAsync()
        {
            var navTitleComponents = await db.NavTitleComponents
                                                                .Include(c => c.MarketTitleComponents)
                                                                .ThenInclude(c => c.MarketComponents)
                                                                .ThenInclude(c => c.MarketSubComponents)
                                                                .Include(c => c.MarketTitleComponents)
                                                                .ThenInclude(c => c.Location)
                                                                .Include(c => c.CertificateComponents)
                                                                .Include(c => c.NavComponents)
                                                                .ToListAsync();
            return navTitleComponents;
        }

        public async Task<List<NavTitleComponent>> GetHomeComponentsAsync()
        {
            var homeComponents = await db.NavTitleComponents
                                                            .Where(c => c.HasMainComponent)
                                                            .Take(3)
                                                            .ToListAsync();
            return homeComponents;
        }

        public async Task<List<SelectListItem>> GetSelectItemsAsync()
        {
            var navTitleComponents = await db.NavTitleComponents.Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Title_EN
            })
                .ToListAsync();

            return navTitleComponents;
        }
    }
}
