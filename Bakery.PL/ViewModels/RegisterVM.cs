
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.ViewModels
{
    public class RegisterVM
    {

        [MaxLength(100)]
        [Required(ErrorMessage ="first name is required..")]
        public string FirstName { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "last name is required..")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Remote(action: "IsEmailAvailable", controller: "Account", ErrorMessage = "Email is already in use")]
        [Required(ErrorMessage = "email is required..")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
         ErrorMessage = "Password must be at least 8 characters, contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassord { get; set; }


        [Required(ErrorMessage = "phone number is required..")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "country is required..")]
        public string Country { get; set; }

        [Required(ErrorMessage = "city is required..")]
        public string City { get; set; }

        [Required(ErrorMessage = "Address is required..")]
        public string Address { get; set; }
  

    }
}
