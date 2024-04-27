using Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface INavTitleComponentRepository : IRepository<NavTitleComponent>
    {
        Task<List<SelectListItem>> GetSelectItemsAsync();

        Task<List<NavTitleComponent>> GetHomeComponentsAsync();
    }
}
