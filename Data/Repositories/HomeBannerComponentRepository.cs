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
    public class HomeBannerComponentRepository : Repository<HomeBannerComponent>, IHomeBannerComponentRepository
    {
        private readonly PolymerContext db;

        public HomeBannerComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async Task<HomeBannerComponent> GetAsync()
        {
            var homeBannerComponent = await db.HomeBannerComponent.FirstOrDefaultAsync();
            return homeBannerComponent;
        }
    }
}
