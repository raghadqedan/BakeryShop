using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public  class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ImageName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        
        public string Description { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }= new HashSet<OrderDetails>();
       
    }
}
