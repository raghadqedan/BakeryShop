using Bakery.BLL.IRepositories;
using Bakery.DAL.Data;
using Bakery.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.Repositories
{
    public class CategoryRepository: GenericRepository<Category> ,ICategoryRepository
    {
     

        public CategoryRepository(ApplicationDbContext dbContext):base(dbContext)
        {
          
        }
       
    }
}
