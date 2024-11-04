using AutoMapper;
using Bakery.BLL.IRepositories;
using Bakery.BLL.Repositories;
using Bakery.DAL.Models;
using Bakery.PL.Areas.Dashboard.ViewModels.category;
using Bakery.PL.Helper;
using Bakery.PL.Mapping;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
     //[Authorize(Roles ="Admin,SuperAdmin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryReprository;
        private readonly IMapper mapper;

        public CategoryController(ICategoryRepository _categoryReprository,IMapper _mapper)
        {
            categoryReprository = _categoryReprository;
            mapper = _mapper;
        }



        [HttpGet]
        public IActionResult Index()
        {
            var model = categoryReprository.GetAll();
            if (model == null)
            {
                return NotFound();
            }
            var categoriesVm = mapper.Map<IEnumerable<CategoryVM>>(model);

            return View(categoriesVm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryFormVM categoryVm)
        {

            if (ModelState.IsValid)
            {
               
                    var fileName = FilesSettings.UploadFile(categoryVm.Image, "images");
                    categoryVm.ImageName = fileName;
                    var categoryModel = mapper.Map<Category>(categoryVm);
                    categoryReprository.Add(categoryModel);
                    return RedirectToAction(nameof(Index));
                
           
            }
            return View(categoryVm);
       
        }
        [HttpGet]
        public IActionResult Details(int? Id)
        {
            if (Id is null)
            {
                return BadRequest();
            }
            var model = categoryReprository.Get(Id.Value);
            if (model is null)
            {
                return NotFound();
            }
            var CategoryVM = mapper.Map<CategoryVM>(model);

            return View(CategoryVM);


        }
        [HttpGet]
        public IActionResult Edit(int? Id) {
            if(Id is null)
            {
                return BadRequest();
            }
            var model = categoryReprository.Get(Id.Value);
            if (model is null)
            {
                return NotFound();
            }
            var categoryVM = mapper.Map<CategoryFormVM>(model);
            return View(categoryVM);
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryFormVM categoryVM)
        {
           /* var model = categoryReprository.Get(categoryVM.Id);
            if(model is null)
           {
                return NotFound(); 
            }
            */
            if (categoryVM.Image is null)
            {
                ModelState.Remove("Image");
            }
            else
            {

                FilesSettings.DeleteFile(categoryVM.ImageName, "images");
                var fileName = FilesSettings.UploadFile(categoryVM.Image, "images");
                categoryVM.ImageName = fileName;
            }
       
            if (!ModelState.IsValid)
            {
                return View(categoryVM);

              
             }

           
            
             var model = mapper.Map<Category>(categoryVM);
           
            categoryReprository.Update(model);
         
            return RedirectToAction(nameof(Index));





        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            var category = categoryReprository.Get(Id);
            if( category is null)
            {
                return NotFound();
            }
            FilesSettings.DeleteFile(category.ImageName, "images");
            categoryReprository.Delete(Id);
           return  RedirectToAction("Index");
 }














    }
}


