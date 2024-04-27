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
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly PolymerContext db;

        public EventRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async override Task<List<Event>> GetAllAsync()
        {
            var events = await db.Events
                                    .OrderByDescending(n => n.Date)
                                    .ToListAsync();
            return events;
        }

        public async Task<Event> GetBySlugAsync(string slug)
        {
            var @event = await db.Events
                            .FirstOrDefaultAsync(n => n.Slug == slug);
            return @event;
        }
    }
}
