using Bakery.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.PL.Areas.Dashboard.ViewModels.orders
{
    public class OrderVM
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; } = null!;
      
        public string ApplicationUser_Id { get; set; }

    
        public virtual ApplicationUser? ApplicationUser { get; set; }

    }
}
