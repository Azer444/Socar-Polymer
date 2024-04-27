using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IMarketSubComponentFileRepository : IRepository<MarketSubComponentFile>
    {
        Task<List<MarketSubComponentFile>> GetAllByMarketComponentSubComponentId(int? id);
    }
}
