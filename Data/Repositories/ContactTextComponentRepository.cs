using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ContactTextComponentRepository : Repository<ContactTextComponent>, IContactTextComponentRepository
    {
        private readonly PolymerContext db;

        public ContactTextComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async Task<ContactTextComponent> GetAsync()
        {
            var contactTextComponent = await db.ContactTextComponent.FirstOrDefaultAsync();
            return contactTextComponent;
        }
    }
}
