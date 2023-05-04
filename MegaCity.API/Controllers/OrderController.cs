using MegaCity.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("controller")]
    [ApiController]
    public class OrderListController : Controller
    {
        [HttpGet()]
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
    }
}
