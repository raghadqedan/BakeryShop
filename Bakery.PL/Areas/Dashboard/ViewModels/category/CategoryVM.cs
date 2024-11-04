using Bakery.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.Areas.Dashboard.ViewModels.category
{
    public class CategoryVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name Is Requierd .... ")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50 Char")]
        public string Name { get; set; } = null!;


        [Required(ErrorMessage = "Description Is Requierd .... ")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50 Char")]
        [MinLength(4, ErrorMessage = "Name Min Length Is 5 Char")]
        public string Description { get; set; }


        public string ImageName { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
