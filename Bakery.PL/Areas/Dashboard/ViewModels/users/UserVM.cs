using Bakery.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.Areas.Dashboard.ViewModels.users
{
    public class UserVM
    {
        public string Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string  LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }






    }
}
