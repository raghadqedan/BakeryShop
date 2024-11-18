using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.ViewModels
{
    public class LoginVM
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Passsword is required")]
        public string Password { get; set; }
        [Display(Name = "Remember Me ?")]
        public bool RememberMe { get; set; }
    }
}
