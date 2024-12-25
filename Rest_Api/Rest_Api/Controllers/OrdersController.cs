using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;






namespace Rest_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersContext _context;

        public OrdersController(OrdersContext context)
        {
            _context = context;
        }

        // GET: api/orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdersRegistration>>> GetAllOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return Ok(orders);
        }


        // Получить ведомость заказов на определенный день
        [HttpGet("report/{date}")]
        public async Task<ActionResult<IEnumerable<OrdersRegistration>>> GetOrdersReport(DateTime date)
        {
            var orders = await _context.Orders
                .Where(o => o.OrderDate.Date == date.Date)
                .ToListAsync();

            return Ok(orders);
        }

    }
}
