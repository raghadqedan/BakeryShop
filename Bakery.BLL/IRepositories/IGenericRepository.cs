using Bakery.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.IRepositories
{
    public  interface IGenericRepository<T> where T:class
    {
        public T Get(int Id);

        public IEnumerable<T> GetAll();
        public void Add(T model);
        public void Update(T model);
        public void Delete(int Id);

    }
}
