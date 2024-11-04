using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public  class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; } = null!;
        public virtual ICollection<OrderDetails> OrderDetail { get; set; } = new HashSet<OrderDetails>();

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUser_Id { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }

     

    }
}
