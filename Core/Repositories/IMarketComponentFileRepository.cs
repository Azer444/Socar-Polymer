using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IMarketComponentFileRepository : IRepository<MarketComponentFile>
    {
        Task<List<MarketComponentFile>> GetAllByMarketComponentId(int? id);
    }
}
