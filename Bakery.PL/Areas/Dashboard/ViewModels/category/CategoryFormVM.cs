using System.ComponentModel.DataAnnotations;

namespace Bakery.PL.Areas.Dashboard.ViewModels.category

{
    public class CategoryFormVM
    {
      

        [Required(ErrorMessage = "Name Is Requierd .... ")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50 Char")]
        public string Name { get; set; } = null!;


        [Required(ErrorMessage = "Description Is Requierd .... ")]
        [MaxLength(50, ErrorMessage = "Name Max Length Is 50 Char")]
        [MinLength(4, ErrorMessage = "Name Min Length Is 5 Char")]
        public string Description { get; set; }


        public IFormFile Image { get; set; }

        public string? ImageName { get; set; }


    }
}
