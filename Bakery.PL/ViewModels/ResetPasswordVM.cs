using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.ViewModels
{
    public class ResetPasswordVM
    {

        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
        ErrorMessage = " Password must be at least 8 characters, contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassord { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

    }
}
