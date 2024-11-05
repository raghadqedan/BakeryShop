using Bakery.DAL.DTO;
using Bakery.DAL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.IRepositories
{
    public interface IUserRepository
    {
        public  Task<IEnumerable<UserDTO>> GetAllUsersWithRole();

        public  Task<IEnumerable<IdentityRole>> GetAllRoles();
        public Task<IEnumerable<string?>> GetRoleByUser(ApplicationUser user);
        public  Task AddUserToRole(ApplicationUser user,string roleId);

        public  Task<IEnumerable<UserDTO>> GetAllAdminOrSuperAdminUsers();
        public  Task<IEnumerable<CustomerDTO>> GetAllCustomer();
        public Task<IdentityResult> Add(ApplicationUser model, string password);
        public Task<ApplicationUser> Get(String Id);
        public Task<ApplicationUser> GetByEmailAsync(string email);
        
        public Task Update(ApplicationUser model);

        public Task Delete(string Id);




    }
}
