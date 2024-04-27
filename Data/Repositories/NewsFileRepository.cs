using Core.Models;
using Core.Repositories;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class NewsFileRepository : Repository<NewsFile>, INewsFileRepository
    {
        private readonly PolymerContext db;

        public NewsFileRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }
    }
}
