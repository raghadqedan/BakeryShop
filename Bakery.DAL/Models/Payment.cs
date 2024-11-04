using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public  class Payment
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public string PaymentStatus { get; set; } = null!;
        public decimal TotalAmountPaid { get; set; }
        public DateTime PaymentDtae { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUser_Id { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }

    }
}
