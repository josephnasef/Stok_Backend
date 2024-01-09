using BAL.interfaces;
using DataAL.Models;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var orders = _orderRepository.GetAllBind();
            return Ok(orders);
        }

        [HttpPost]
        public ActionResult<Order> CreateOrder(Order order)
        {
            var createdOrder = _orderRepository.Add(order);

            return CreatedAtAction(nameof(GetOrders), new { id = createdOrder.StockID }, createdOrder);
        }
    }
}
