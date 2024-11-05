using Bakery.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.PL.Areas.Dashboard.ViewModels.Product
{
    public class ProductVM
    {
        public int Id { get; set; }

     
        public string Name { get; set; } = null!;

       
        public string ImageName { get; set; }

        public int StockQuantity { get; set; }


        public decimal Price { get; set; }

        // Add this property to access Category_Id
        public int? Category_Id { get; set; }

    }
}
