using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.ViewModels
{
    public class ForgotPasswordVM
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email is requierd..")]
        public string Email { get; set; }
    }
}
