using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ICertificateComponentRepository : IRepository<CertificateComponent>
    {
        Task RegulateSlugAsync(CertificateComponent certificateComponent);

        Task<CertificateComponent> GetBySlugAsync(string slug);
    }
}
