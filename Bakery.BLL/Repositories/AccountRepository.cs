using Bakery.BLL.IRepositories;
using Bakery.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AccountRepository(UserManager<ApplicationUser> userManager) {
            this.userManager = userManager;
        }
        public async Task<IdentityResult> Register(ApplicationUser user,string password)
        {
          
                var result=await userManager.CreateAsync(user, password);
                return result;
            
        }

        public async Task<ApplicationUser> GetByEmailAsync(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }

        public Task<bool> CheckPasswordAsync(ApplicationUser user,string password)
        {
           return  userManager.CheckPasswordAsync(user, password);
        }

        public async Task<bool> IsInRole(ApplicationUser user, string roleName)
        {
           return await  userManager.IsInRoleAsync(user, roleName);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(ApplicationUser user)
        {
            return await  userManager.GeneratePasswordResetTokenAsync(user);
        }
        public async Task<IdentityResult> ResetPasswordAsync(ApplicationUser user,string token,string password)
        {
            return await userManager.ResetPasswordAsync(user,token,password);
        }
    }
}
