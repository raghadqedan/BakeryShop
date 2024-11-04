using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public class ApplicationUser:IdentityUser
    {
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
        public string? Country { get; set; }

        public string? City { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();


        public virtual ICollection<Cart> Cart { get; set; } = new HashSet<Cart>();
        public virtual ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();



    }
}
