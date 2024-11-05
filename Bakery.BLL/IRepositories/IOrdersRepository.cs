using Bakery.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.BLL.IRepositories
{
    public  interface IOrdersRepository:IGenericRepository<Order>
    {
        public  Task<IEnumerable<Order>> GetAllOrdersWithUsers();
        public Task<Order> GetOrder(int id);
    }
}
