using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IProductCategoryPropertyRepository : IRepository<ProductCategoryProperty>
    {
        Task<List<ProductCategoryProperty>> GetAllByCategoryAsync(int? id);
    }
}
