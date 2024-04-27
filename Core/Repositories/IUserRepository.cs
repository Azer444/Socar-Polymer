using Core.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetUserAsync(ClaimsPrincipal User);
        Task<IdentityResult> UpdateAsync(User user);
        Task<IdentityResult> CreateAsync(User user, string passsword);
        Task<User> FindByUserNameAsync(string username);
        Task<User> FindByIdAsync(string username);
        Task<User> FindByEmailAsync(string email);
        Task<bool> IsInRoleAsync(User user, string role);
        Task<IdentityResult> AddToRoleAsync(User user, string role);
        Task<IdentityResult> AddToRolesAsync(User user, IEnumerable<string> roles);
        Task<IdentityResult> DeleteAsync(User user);
        Task<string[]> GetUserRolesId(User user);
        Task<IList<string>> GetRolesAsync(User user);
        Task<IdentityResult> RemoveFromRolesAsync(User user, IEnumerable<string> roles);
        Task<List<User>> GetAllStandardAsync();

        Task<List<User>> GetAllWaitingConfirmedAsync();
    }
}
