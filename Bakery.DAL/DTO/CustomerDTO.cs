using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.DTO
{
    public class CustomerDTO
    {
        public string Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }
        public string Country { get; set; }

        public string  City { get; set; }
        public string Address { get; set; }

    }
}
