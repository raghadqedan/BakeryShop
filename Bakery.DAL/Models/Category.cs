using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public  class Category
    {
        public int Id { get; set; }

       
        public string Name { get; set; } = null!;

        public string Description { get; set; }
        public string ImageName { get; set; }

        public DateTime CreateDate { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}
