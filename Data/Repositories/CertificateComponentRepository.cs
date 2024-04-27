using Core.Models;
using Core.Repositories;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CertificateComponentRepository : Repository<CertificateComponent>, ICertificateComponentRepository
    {
        private readonly PolymerContext db;

        public CertificateComponentRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }

        public async override Task<List<CertificateComponent>> GetAllAsync()
        {
            var certificateComponents = await db.CertificateComponents
                                                                .Include(c => c.CertificateComponentFiles)
                                                                .ToListAsync();
            return certificateComponents;
        }

        public async override Task<CertificateComponent> GetAsync(int? id)
        {
            var certificateComponent = await db.CertificateComponents
                                                                .Include(c => c.CertificateComponentFiles)
                                                                .FirstOrDefaultAsync(c => c.Id == id);
            return certificateComponent;
        }

        public async Task<CertificateComponent> GetBySlugAsync(string slug)
        {
            var certificateComponent = await db.CertificateComponents
                                                                   .Include(c => c.CertificateComponentFiles)
                                                                   .FirstOrDefaultAsync(c => c.Slug == slug);
            return certificateComponent;
        }

        public async Task RegulateSlugAsync(CertificateComponent certificateComponent)
        {
            if (await db.CertificateComponents.AnyAsync(p => p.Id != certificateComponent.Id && p.Slug == certificateComponent.Slug))
                certificateComponent.Slug = certificateComponent.Slug + "-" + certificateComponent.Id;

            db.CertificateComponents.Attach(certificateComponent);
            db.Entry(certificateComponent).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
