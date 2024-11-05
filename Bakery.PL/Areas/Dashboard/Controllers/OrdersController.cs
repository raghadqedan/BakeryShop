using AutoMapper;
using Bakery.BLL.IRepositories;
using Bakery.DAL.DTO;
using Bakery.PL.Areas.Dashboard.ViewModels.orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace Bakery.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class OrdersController : Controller
    {
        private readonly IOrdersRepository orderRepository;
        private readonly IMapper mapper;
        private readonly ILogger<OrdersController> logger;

        public OrdersController(IOrdersRepository orderRepository,IMapper mapper, ILogger<OrdersController> logger) {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
            this.logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var orders = await orderRepository.GetAllOrdersWithUsers();
            var vm = mapper.Map<IEnumerable<OrderVM>>(orders);
            return View(vm);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var order =await  orderRepository.GetOrder(Id);
            if (order is null)
            {
                return NotFound();
            }
            var vm = mapper.Map<OrderDetailsVM>(order);
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, [FromBody] OrderStatusUpdateDTO dto) {
            logger.LogInformation(dto.Status);
            var order = await orderRepository.GetOrder(Id);
            if(order is null)
            {
                return NotFound();
            }
            order.OrderStatus = dto.Status;
           orderRepository.Update(order);

            return RedirectToAction(nameof(Index));

        }
    }
}



