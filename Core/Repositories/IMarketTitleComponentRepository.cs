using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IMarketTitleComponentRepository : IRepository<MarketTitleComponent>
    {
        Task RegulateSlugAsync(MarketTitleComponent marketTitleComponent);

        Task<MarketTitleComponent> GetBySlugAsync(string slug);

        Task<List<MarketTitleComponent>> GetAllByLocationAsync(string location);
    }
}
