using AutoMapper;
using Bakery.DAL.DTO;
using Bakery.DAL.Models;
using Bakery.PL.Areas.Dashboard.ViewModels.category;
using Bakery.PL.Areas.Dashboard.ViewModels.Product;
using Bakery.PL.Areas.Dashboard.ViewModels.users;

namespace Bakery.PL.Mapping
{
    public class MappingProfile:Profile
    {
       public MappingProfile()
        {
            CreateMap<Category, CategoryVM>();
            CreateMap<CategoryFormVM, Category>().ReverseMap();
            CreateMap<Product, ProductFormVM>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<ProductDetailsVM, Product>().ReverseMap();
            CreateMap<ApplicationUser, UserVM>().ReverseMap();
            CreateMap<UserFormVM, ApplicationUser>().ReverseMap();
            CreateMap<UserVM, UserDTO>().ReverseMap();
            CreateMap<CustomerVM, CustomerDTO>().ReverseMap();





        }
    }
}
