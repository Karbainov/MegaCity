using MegaCity.API.Models.ModelsInput;
using MegaCity.API.Models.ModelsOutput;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        [HttpPost()]
        public IActionResult AddOrder(OrderRequestModel order)
        {
            OrderResponseModel newOrder = new OrderResponseModel();
            {
                string Name = order.Name;
                int Number = order.Number;
            }

            return Created(new Uri("Order", UriKind.Relative), newOrder);
        }

        [HttpGet("All-Orders")]
        public IActionResult GetAllOrders()
        {
            List<OrderResponseModel> order = new List<OrderResponseModel>()
            {
                new OrderResponseModel()
                {
                    Name = "product1",
                    Number = 5
                },

                new OrderResponseModel()
                {
                    Name = "product2",
                    Number = 10
                },

                new OrderResponseModel()
                {
                    Name = "product3",
                    Number = 3
                },

            };

            return Ok(order);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder()
        {
            OrderResponseModel order = new OrderResponseModel()
            {
                Name = "product",
                Number = 5
            };

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id,OrderRequestModel order)
        {
            OrderResponseModel orderOutput = new OrderResponseModel();
            {
                int Id = id;
                string Name = order.Name;
                int Number = order.Number;
            }

            return Ok(order);
        }
    }
}
