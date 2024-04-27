﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IContactFormComponentRepository : IRepository<ContactFormComponent>
    {
        Task<ContactFormComponent> GetAsync();
    }
}
