using AutoMapper;
using Bakery.BLL.IRepositories;
using Bakery.BLL.Repositories;
using Bakery.DAL.Models;
using Bakery.PL.Helper;
using Bakery.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository accountRepository;
        private readonly SignInManager<ApplicationUser> signinManager;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public AccountController(IAccountRepository accountRepository,SignInManager<ApplicationUser> signinManager,IMapper mapper,
            IUserRepository userRepository)
        {
            this.accountRepository = accountRepository;
            this.signinManager = signinManager;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterVM input)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                { 
                    FirstName = input.FirstName,
                    LastName = input.LastName,
                    Email = input.Email,
                    UserName = input.Email,
                    City = input.City,
                    Country = input.Country,
                    Address = input.Address
                };
                var result = await accountRepository.Register(user, input.Password);
                if (result.Succeeded)
                {
                    var token = await accountRepository.GenerateEmailConfirmationTokenAsync(user);
                    var confirmedUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, protocol: HttpContext.Request.Scheme);
                    var email = new Email()
                    {
                        Subject = "Confirm Email",
                        Recivers = input.Email,
                        Boady = $"Please confirm your email {confirmedUrl}"


                    };
                
                        EmailSettings.SendEmail(email);
                 
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                } 
            }
            return View(input);


        }
        [HttpGet]
         public IActionResult Login()
          {
                return View();
          }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM input)
        {
            if (ModelState.IsValid)
            {
                var currentUser =await  accountRepository.GetByEmailAsync(input.Email);
                if (currentUser != null) {
                    var check = await accountRepository.CheckPasswordAsync(currentUser, input.Password);
                    if (check)
                    {
                        var result=await signinManager.PasswordSignInAsync(currentUser, input.Password, input.RememberMe,false);
                        if (result.Succeeded)
                        {
                            if (await accountRepository.IsInRole(currentUser, "SuperAdmin") || await accountRepository.IsInRole(currentUser, "Admin"))
                            {
                                return RedirectToAction("Index", "Category", new { area = "Dashboard" });

                            }
                            else
                            {
                                return RedirectToAction("Index", "Home");
                            }
                        }
                    }

                        }
            }



            return View(input);
        }



        public async Task<IActionResult> IsEmailAvailable(string email)
        {
            // Check if the email is already taken
            var user = await accountRepository.GetByEmailAsync(email);
            return Json(user == null);  // Returns true if available, false if already taken
        }

        public  IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendResetPasswordUrl( [FromBody] ForgotPasswordVM input)
        {
            if (ModelState.IsValid) {
                var user = await accountRepository.GetByEmailAsync(input.Email);
                var token = await accountRepository.GeneratePasswordResetTokenAsync(user);
                if (user != null)
                {
                    var resetPasswordUrl = Url.Action("ResetPassword", "Account", new { email = input.Email,token = token }, protocol: HttpContext.Request.Scheme); 
                    var email = new Email()
                    {
                        Subject = "Reset Password",
                        Recivers = input.Email,
                        Boady = resetPasswordUrl

                    };
                    
                        EmailSettings.SendEmail(email);
                   
                }
            }
         
            return View("ForgotPassword") ;
        }


        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {

            return View();

        }
        [HttpPost]
        public  async Task<IActionResult> ResetPassword(ResetPasswordVM input)
        {
            if (ModelState.IsValid)
            {
                 var user = await accountRepository.GetByEmailAsync(input.Email);
                 if(user is not null)
                {
                 var result= await accountRepository.ResetPasswordAsync(user, input.Token, input.NewPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Login));
                    }
                }

            }

            return View(input);

        }


         public async Task<IActionResult> ConfirmEmail(string userId,string token) {
            if(userId==null|| token == null)
            {
                return View("Error", "Home");
            }
            var user = userRepository.Get(userId);
            if(user is not null)
            {
              var result= await  userRepository.ConfirmEmailAsync(user.Result, token);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }

            }
            return View("Error", "Home");

        }


        [HttpGet]
        public IActionResult CheckEmail()
        {

            return View();

        }
    }
}

