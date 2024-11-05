using Bakery.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using Bakery.PL.Areas.Dashboard.ViewModels.category;

namespace Bakery.PL.Areas.Dashboard.ViewModels.Product
{
    public class ProductFormVM
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public IFormFile Image { get; set; }
        public string? ImageName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; } = null!;

        public int? Category_Id { get; set; }
        public Category? selectedCategory { get; set; }

        public IEnumerable<CategoryVM>?Categories { get; set; }

    }
}
