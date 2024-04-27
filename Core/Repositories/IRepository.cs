using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task UpdateAsync(T data);
        Task CreateAsnyc(T data);
        Task DeleteAsync(int? id);
    }
}
