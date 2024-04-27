using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        private readonly PolymerContext db;

        public LocationRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public List<string> GetNames()
        {
            var locations = db.Locations
                                    .Select(l => l.Name.ToLower())
                                    .ToList();
            return locations;
        }

        public async Task<List<SelectListItem>> GetSelectItemsAsync()
        {
            var locations = await db.Locations.Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            })
                .ToListAsync();

            return locations;
        }
    }
}
