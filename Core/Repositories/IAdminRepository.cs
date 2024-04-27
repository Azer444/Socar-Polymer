﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IAdminRepository
    {
        Task<List<IdentityUser>> GetAdminsAsync();
    }
}
