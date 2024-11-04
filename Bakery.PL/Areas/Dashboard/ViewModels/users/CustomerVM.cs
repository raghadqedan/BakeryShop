using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.Areas.Dashboard.ViewModels.users
{
    public class CustomerVM
    {
        public string Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }
        public string? Country { get; set; }

        public string? City { get; set; }
        public string? Address { get; set; }
    }
}
