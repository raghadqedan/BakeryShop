using Bakery.BLL.IRepositories;
using Bakery.DAL.Data;
using Bakery.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.Repositories
{
    public  class GenericRepository<T>: IGenericRepository<T>where T:class
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void Add(T model)
        {
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var model = dbContext.Set<T>().Find(Id);
            if(model is not  null)
            {
                dbContext.Set<T>().Remove(model);
                dbContext.SaveChanges();

            }
           
        }

        public T Get(int Id)
        {

            return dbContext.Set<T>().Find(Id); ;


        }

        public IEnumerable<T> GetAll()
        {
            var models = dbContext.Set<T>().AsNoTracking().ToArray();
            return models;
        }

        public void Update(T model)
        {
            dbContext.Set<T>().Update(model);
            dbContext.SaveChanges();
        }
    }
}
