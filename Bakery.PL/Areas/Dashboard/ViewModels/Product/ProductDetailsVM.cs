using Bakery.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.PL.Areas.Dashboard.ViewModels.Product
{
    public class ProductDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ImageName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;

        public DateTime CreateDate { get; set; }

    }
}
