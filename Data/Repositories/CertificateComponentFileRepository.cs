using Core.Models;
using Core.Repositories;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class CertificateComponentFileRepository : Repository<CertificateComponentFile>, ICertificateComponentFileRepository
    {
        private readonly PolymerContext db;

        public CertificateComponentFileRepository(PolymerContext db)
            :base(db)
        {
            this.db = db;
        }
    }
}
