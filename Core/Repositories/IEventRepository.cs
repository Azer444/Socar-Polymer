using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<Event> GetBySlugAsync(string slug);
    }
}
