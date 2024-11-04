using Bakery.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.IRepositories
{
    public  interface IProductRepository:IGenericRepository<Product>
    {
       
    }
}
