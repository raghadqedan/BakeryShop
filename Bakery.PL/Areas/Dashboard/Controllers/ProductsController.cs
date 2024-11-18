using AutoMapper;
using Bakery.BLL.IRepositories;
using Bakery.BLL.Repositories;
using Bakery.DAL.Models;
using Bakery.PL.Areas.Dashboard.ViewModels.category;
using Bakery.PL.Areas.Dashboard.ViewModels.Product;
using Bakery.PL.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Bakery.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;
        private readonly ICategoryRepository categoryRepository;

        public ProductsController(IProductRepository productRepository,IMapper mapper,ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        //getAll
        public IActionResult Index()
        {
            var products = productRepository.GetAll();
            var productsVM = mapper.Map<IEnumerable<ProductVM>>(products);



            Dictionary<int, string> categoryNames = new Dictionary<int, string>();

            // Loop through products and get category names
            foreach (var product in products)
            {
               
                    var category = categoryRepository.Get(product.Category_Id); // Get the category using Category_Id
                    if (category != null)
                    {
                        categoryNames[product.Category_Id] = category.Name; // Store category name by Category_Id
                    }
                
            }

            // Store the category names in ViewBag
            ViewBag.CategoryNames = categoryNames;

            return View(productsVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
   
           var categories= mapper.Map<IEnumerable<CategoryVM>>(categoryRepository.GetAll());


            return View(new ProductFormVM{Categories = categories }); 


        }
        [HttpPost]
        public IActionResult Create(ProductFormVM productVm)
        {
            if (!ModelState.IsValid)
            {
                return View(productVm);

            }
            productVm.ImageName = FilesSettings.UploadFile(productVm.Image, "images");
            var productModel = mapper.Map<Product>(productVm);
            productRepository.Add(productModel);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if(Id is null ||Id<0)
            {
                return BadRequest();
            }
            
            var product = productRepository.Get(Id.Value);
            if(product is null)
            {
                return NotFound();
            }
            var vm = mapper.Map<ProductDetailsVM>(product);
            ViewBag.CategoryName= categoryRepository.Get(product.Category_Id).Name;
            
            return View(vm);

        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {   
            var product = productRepository.Get(Id);
            
            var categories = categoryRepository.GetAll(); // Ensure this returns IEnumerable<Category>

            // Populate ViewData with categories for the dropdown
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            var currentCategory = categoryRepository.Get(product.Category_Id);
            ViewData["SelectedCategoryName"] = currentCategory.Name;
            
            return View(mapper.Map<ProductFormVM>(product));


        }
        public IActionResult Edit(ProductFormVM productVM) {
         
        
        if(productVM.Image is null)
            {
                ModelState.Remove("Image");
            }
            else
            { FilesSettings.DeleteFile(productVM.ImageName, "images");
                productVM.ImageName = FilesSettings.UploadFile(productVM.Image, "images");

            }
            if (!ModelState.IsValid) {
                return View(productVM);
            }
            var productmodel = mapper.Map<Product>(productVM);
            productRepository.Update(productmodel);
            return RedirectToAction(nameof(Index));
         
        
        }



        [HttpPost]
        public IActionResult Delete(int? Id)
        {
            if(Id is null || Id.Value < 0)
            { return BadRequest(); }

            var product  = productRepository.Get(Id.Value);
            if(product is null)
            {
                return NotFound();
            }
            productRepository.Delete(Id.Value);
            return RedirectToAction("Index");
        }

    }
}
