using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public  class CartDetails
    {
        public int Id { get; set; }
        public int Cart_Id { get; set; }
        public int Product_Id { get; set; }
        public decimal Quantity { get; set; }

    }
}
