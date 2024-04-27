using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly PolymerContext db;
        private readonly DbSet<T> dbTable;

        public Repository(PolymerContext db)
        {
            this.db = db;
            dbTable = db.Set<T>();
        }

        public async Task CreateAsnyc(T data)
        {
            await dbTable.AddAsync(data);
        }

        public async Task DeleteAsync(int? id)
        {
            var data = await dbTable.FindAsync(id);
            dbTable.Remove(data);
        }

        public async Task UpdateAsync(T data)
        {
            dbTable.Attach(data);
            db.Entry(data).State = EntityState.Modified;
        }

        public async virtual Task<T> GetAsync(int? id)
        {
            var data = await dbTable.FindAsync(id);
            return data;
        }

        public async virtual Task<List<T>> GetAllAsync()
        {
            return await dbTable.ToListAsync();
        }
    }
}
