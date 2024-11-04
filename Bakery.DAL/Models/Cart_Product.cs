using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public class Cart_Product
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Cart))]
        public int Cart_Id { get; set; }
        public virtual Cart? Cart { get; set; }

        [ForeignKey(nameof(Product))]
        public int Product_Id { get; set; }
        public virtual Product? Product { get; set; }

        public decimal Quntity { get; set; }


    }
}
