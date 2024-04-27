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
    public class NewsRepository : Repository<News>, INewsRepository
    {
        private readonly PolymerContext db;

        public NewsRepository(PolymerContext db)
            : base(db)
        {
            this.db = db;
        }

        public async override Task<List<News>> GetAllAsync()
        {
            var news = await db.News
                                    .Include(n => n.NewsFiles)
                                    .OrderByDescending(n => n.CreatedAt)
                                    .ToListAsync();
            return news;
        }

        public async override Task<News> GetAsync(int? id)
        {
            var news = await db.News
                            .Include(n => n.NewsFiles)
                            .FirstOrDefaultAsync(n => n.Id == id);
            return news;
        }

        public async Task<News> GetBySlugAsync(string slug)
        {
            var news = await db.News
                             .Include(n => n.NewsFiles)
                             .FirstOrDefaultAsync(n => n.Slug == slug);
            return news;
        }
    }
}
