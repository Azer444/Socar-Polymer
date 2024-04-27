using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ProductContactMessageRepository : Repository<ProductContactMessage>, IProductContactMessageRepository
    {
        private readonly PolymerContext _context;

        public ProductContactMessageRepository(PolymerContext context)
            :base(context)
        {
            _context = context;
        }

        public override async Task<List<ProductContactMessage>> GetAllAsync()
        {
            return await _context.ProductContactMessages.OrderByDescending(pcm => pcm.Id).ToListAsync();
        }
    }
}
