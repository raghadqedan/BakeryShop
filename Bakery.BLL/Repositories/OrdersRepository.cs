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
    public class OrdersRepository : GenericRepository<Order>, IOrdersRepository
    {
        private readonly ApplicationDbContext dbContext;

        public OrdersRepository(ApplicationDbContext _dbContext) : base(_dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersWithUsers()
        {
           
                return await dbContext.Orders.Include(x => x.ApplicationUser).ToListAsync();

            
        }
        public async Task<Order> GetOrder(int id)
        {
            return await dbContext.Orders
                .Include(order => order.ApplicationUser).Include(order=>order.OrderDetail)// Include related ApplicationUser
            .ThenInclude(detail => detail.Product)
                .FirstOrDefaultAsync(order => order.Id == id); // Find the order by Id
        }


    }
}
