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
    public class ContactFormComponentRepository : Repository<ContactFormComponent>, IContactFormComponentRepository
    {
        private readonly PolymerContext db;

        public ContactFormComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async Task<ContactFormComponent> GetAsync()
        {
            var contactFormComponent = await db.ContactFormComponent.FirstOrDefaultAsync();
            return contactFormComponent;
        }
    }
}
