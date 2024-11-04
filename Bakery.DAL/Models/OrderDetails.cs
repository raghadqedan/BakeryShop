using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        [ForeignKey(nameof(Product))]
        public int Product_Id { get; set; }
        public virtual Product? Product { get; set; }

        [ForeignKey(nameof(Order))]
        public int Order_Id {get;set;}
        public virtual Order? Order { get; set; }

    }
}
