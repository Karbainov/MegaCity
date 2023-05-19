using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        OrderService _orderService;
        Mapper _mapper;

        public OrderController()
        {
            _orderService = new OrderService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet("All-Orders")]
        public IActionResult GetAllOrders()
        {
            List<OrderModel> orders = _orderService.GetAllOrders();
            List<OrderResponseModel> allOrders = _mapper.Map<List<OrderResponseModel>>(orders);

            return Ok(allOrders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            OrderModel order = _orderService.GetOrderById();
            OrderResponseModel orderId = _mapper.Map<OrderResponseModel>(order);

            return Ok(orderId);
        }

        [HttpPost()]
        public IActionResult AddOrder(int userId, OrderRequestModel order)
        {
            OrderModel orderModel = _mapper.Map<OrderModel>(order); //выдает ошибку 500
            OrderModel newOrder  = _orderService.AddOrder(userId, orderModel);
            OrderResponseModel result= _mapper.Map<OrderResponseModel>(newOrder);

            return Created(new Uri("Order", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrderById(int id,OrderRequestModel order)
        {
            OrderModel orderModel = _mapper.Map<OrderModel>(order);
            _orderService.UpdateOrderById(id, orderModel);
            OrderResponseModel orderOutput = _mapper.Map<OrderResponseModel>(orderModel);

            return Ok(order);
        }
    }
}
