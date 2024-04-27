using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IMarketSubComponentRepository : IRepository<MarketSubComponent>
    {
        Task RegulateSlugAsync(MarketSubComponent marketComponent);

        Task<MarketSubComponent> GetBySlugAsync(string slug);
    }
}
