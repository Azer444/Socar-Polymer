﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface INewsRepository : IRepository<News>
    {
        Task<News> GetBySlugAsync(string slug);
    }
}
