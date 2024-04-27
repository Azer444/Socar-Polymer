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
    public class ContactMessageRepository : Repository<ContactMessage>, IContactMessageRepository
    {
        private readonly PolymerContext db;

        public ContactMessageRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public override async Task<List<ContactMessage>> GetAllAsync()
        {
            var contactMessages = await db.ContactMessages
                                                        .OrderByDescending(c => c.Id)
                                                        .ToListAsync();
            return contactMessages;
        }
    }
}
