using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IMarketComponentRepository : IRepository<MarketComponent>
    {
        Task RegulateSlugAsync(MarketComponent marketComponent);

        Task<MarketComponent> GetBySlugAsync(string slug);
    }
}
