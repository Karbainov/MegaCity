using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("controller")]
    [ApiController]
    public class OrderListController : Controller
    {
        [HttpPost()]
        public IActionResult AddOrder(OrderInputModel order)
        {
            OrderOutputModel newOrder = new OrderOutputModel();
            {

               string Name = order.Name;
               int  Number = order.Number;
            }

            return Created(new Uri("Order", UriKind.Relative), newOrder);
        }
         
        [HttpGet("{id}")]
        public IActionResult GetAllOrders()
        {
            List<OrderOutputModel> order = new List<OrderOutputModel>()
            {
                new OrderOutputModel()
                {
                    Name="product1",

                    Number=5
                },

                new OrderOutputModel()
                {
                    Name="product2",

                    Number=10
                },

                new OrderOutputModel()
                {
                    Name="product3",

                    Number=3
                },

            };

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id,OrderInputModel order)
        {
            OrderOutputModel orderOutput = new OrderOutputModel();
            {
                int Id = id;
                string Name = order.Name;
                int Number = order.Number;
            }
            return Ok(order);
        }
    }
}
