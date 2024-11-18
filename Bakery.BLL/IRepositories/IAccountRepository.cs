using Bakery.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.IRepositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> Register(ApplicationUser user, string password);
        public Task<ApplicationUser> GetByEmailAsync(string email);
        public Task<bool> CheckPasswordAsync(ApplicationUser user, string password);
        public Task<bool> IsInRole(ApplicationUser user, string roleName);
        public Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user);
        public Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser user);
        public Task<IdentityResult> ResetPasswordAsync(ApplicationUser user, string token, string password);





    }
}
