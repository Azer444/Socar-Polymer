using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class HomeSliderComponentRepository : Repository<HomeSliderComponent>, IHomeSliderComponentRepository
    {
        private readonly PolymerContext db;

        public HomeSliderComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async override Task<List<HomeSliderComponent>> GetAllAsync()
        {
            var homeSliderComponents = await db.HomeSliderComponents
                                                                    .OrderByDescending(c => c.Id)
                                                                    .ToListAsync();
            return homeSliderComponents;
        }
    }
}
