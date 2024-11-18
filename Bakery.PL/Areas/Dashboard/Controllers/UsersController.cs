using AutoMapper;
using Bakery.BLL.IRepositories;
using Bakery.BLL.Repositories;
using Bakery.DAL.Models;
using Bakery.PL.Areas.Dashboard.ViewModels.users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bakery.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    
    public class UsersController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;



        public UsersController(IUserRepository userRepository, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.userManager = userManager;
            
        }
        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Index()
        {
            var usersDto = await userRepository.GetAllAdminOrSuperAdminUsers();
            var vm = mapper.Map<IEnumerable<UserVM>>(usersDto);
            return View(vm);
          


          /*  var vm = mapper.Map<IEnumerable<UserVM>>(users);
            Dictionary<string, string> roles = new Dictionary<string, string>();
            foreach (var user in users) {
                var role = await userManager.GetRolesAsync(user);
                if (role != null)
                {
                    
                    roles[user.Id] = role.FirstOrDefault()??"No Role Assigned";
                }
            
            }
            ViewBag.roles = roles;
            return View(vm);
          */

        }
        [HttpGet]
        [Authorize(Roles = "SuperAdmin,Admin")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var usersDto = await userRepository.GetAllCustomer();
            var vm = mapper.Map<IEnumerable<CustomerVM>>(usersDto);
            return View("CustomersIndex",vm);

        }


        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Create() {
            var roles = await userRepository.GetAllRoles();
            var userVM = new UserFormVM { Roles = roles };

            return View(userVM);
        }
        [HttpPost]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Create(UserFormVM input)
        {
            
            if (!ModelState.IsValid)
            {   //refetching the list when re-rendering the Create view.
                input.Roles = await userRepository.GetAllRoles();
                return View(input);
            }
           
            var model = mapper.Map<ApplicationUser>(input);
            model.UserName = input.Email;
            var result = await userRepository.Add(model, input.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(input.Password, error.Description);
                   
                }
                //refetching the list when re-rendering the Create view.
                input.Roles = await userRepository.GetAllRoles();
                return View(input);
            }

             await userRepository.AddUserToRole(model,input.RoleId);
            return RedirectToAction(nameof(Index));

        }
            public async Task<IActionResult> IsEmailAvailable(string email)
            {
            // Check if the email is already taken
            var user = await userRepository.GetByEmailAsync(email);
                return Json(user == null);  // Returns true if available, false if already taken
            }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Details(string Id)
        {
            
            var user = await userRepository.Get(Id) ;
            if(user is  null)
            {
                return NotFound();

            }
            var vm = mapper.Map<UserVM>(user);
           var result= await userRepository.GetRoleByUser(user);
            if (result.Any())
            {
                vm.RoleName = result.FirstOrDefault ()?? "No Role Assigned";
            }
            return View(vm);

        }
        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult>Edit(string Id)
        {
            var model = await userRepository.Get(Id);
            if(model is null)
            {
                return NotFound();
            }
            var vm = mapper.Map<UserFormVM>(model);
            vm.Roles = await userRepository.GetAllRoles();
            var roles = await userRepository.GetRoleByUser(model);
            
            ViewBag.roleName = roles.FirstOrDefault()??"No Role Assigned";
            return View(vm);
        }

        [Authorize(Roles = "SuperAdmin")]
        public async Task Delete(string Id)
        {
           await  userRepository.Delete(Id);

        }
        
   }
}


