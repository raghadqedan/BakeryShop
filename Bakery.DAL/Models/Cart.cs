using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.DAL.Models
{
    public  class Cart
    {
        public int Id { get; set; }
        //public int user_id { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUser_Id { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }



    }
}
