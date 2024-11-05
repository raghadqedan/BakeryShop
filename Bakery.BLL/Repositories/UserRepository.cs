using Bakery.BLL.IRepositories;
using Bakery.DAL.Data;
using Bakery.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Bakery.DAL.DTO;
using System.Data;

namespace Bakery.BLL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserRepository(ApplicationDbContext _dbContext,UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager ) 
        {
            dbContext = _dbContext;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersWithRole()
        {
            var users = await dbContext.Users.ToListAsync();

            var usersWithRoles = new List<UserDTO>();
            foreach (var user in users)
            {
             
                var userDto = new UserDTO
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
               
                };

                var roles = await userManager.GetRolesAsync(user);
                userDto.RoleName = roles.FirstOrDefault() ?? "No Role Assigned";
                usersWithRoles.Add(userDto);

            }
            return usersWithRoles;
        }

   
   

        public async Task<IEnumerable<IdentityRole>> GetAllRoles()
        {
            return await roleManager.Roles.ToListAsync();
        }

        public async Task AddUserToRole(ApplicationUser user, string  roleId)
        {
            await userManager.AddToRoleAsync(user, (await roleManager.FindByIdAsync(roleId)).Name);
        }


        public async Task<IEnumerable<UserDTO>> GetAllAdminOrSuperAdminUsers()
        {
            var users = await dbContext.Users.ToListAsync();

            var usersWithRolesAdminAndSuperAdmin = new List<UserDTO>();
            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                var roleName = roles.FirstOrDefault() ?? "No Role Assigned";
                if(roleName.Equals("Admin")|| roleName.Equals("SuperAdmin"))
                {
                    var userDto = new UserDTO
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        RoleName = roleName
                    };


                    usersWithRolesAdminAndSuperAdmin.Add(userDto);

                }
                

            }
            return usersWithRolesAdminAndSuperAdmin;
        }
        //get All customer
        public async Task<IEnumerable<CustomerDTO>> GetAllCustomer()
        {
            var users = await dbContext.Users.ToListAsync();

            var customers = new List<CustomerDTO>();
            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                var roleName = roles.FirstOrDefault() ?? "No Role Assigned";
                if (roleName.Equals("User"))
                {
                    var userDto = new CustomerDTO
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        RoleName = roleName,
                        City=user.City??"Unknown",
                        Country=user.Country?? "Unknown",
                        Address=user.Address?? "Unknown",
                    };


                    customers.Add(userDto);

                }

            }
            return customers;
        }



        public async Task<IdentityResult> Add(ApplicationUser model, string password)
        {
            var result = await userManager.CreateAsync(model, password);
            return result;
        }

        public async  Task<ApplicationUser> Get(string Id)
        {
           var user=await  userManager.FindByIdAsync(Id);
            return user;
        }

        public async Task Delete(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if(user is  not null)
            userManager.DeleteAsync(user);
        }

        public async Task<IEnumerable<string?>> GetRoleByUser(ApplicationUser user)
        {
           var roles= await userManager.GetRolesAsync(user);
            return roles;
        }

        public async Task Update(ApplicationUser model)
        {
           await  userManager.UpdateAsync(model);
        }

        public async Task<ApplicationUser> GetByEmailAsync(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }
    }
}
