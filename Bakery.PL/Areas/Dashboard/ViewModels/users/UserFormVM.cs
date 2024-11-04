using Bakery.PL.Areas.Dashboard.ViewModels.category;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.Areas.Dashboard.ViewModels.users
{
    public class UserFormVM
    {

        public string Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailAvailable", controller: "Users", ErrorMessage = "Email is already in use")]
        public virtual string Email { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = "Password must be at least 8 characters, contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string VerifyPassword { get; set; }

        public string RoleId { get; set; }
        public IEnumerable<IdentityRole>? Roles { get; set; }

        public  string PhoneNumber { get; set; }


    }
}
