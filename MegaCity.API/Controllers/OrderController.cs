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
            var orders = _mapper.Map<List<OrderResponseModel>>(_orderService.GetAllOrders());

            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var a = _orderService.GetOrderById(id);
            var order = _mapper.Map<OrderResponseModel>(a);

            return Ok(order);
        }

        [HttpPost()]
        public IActionResult AddOrder(OrderRequestModel order)
        {
            List<OrderPositionModel> orderPositions = _mapper.Map<List<OrderPositionModel>>(order.Positions);
            var newOrder  = _orderService.AddOrder(order.UserId, orderPositions);
            OrderResponseModel result= _mapper.Map<OrderResponseModel>(newOrder);

            return Created(new Uri("Order", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderById(int id)
        {
            _orderService.DeleteOrderById(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrderById(int id,OrderRequestModel order)
        {
            OrderModel orderModel = _mapper.Map<OrderModel>(order);
            orderModel.Id = id;
            OrderModel newOrder = _orderService.UpdateOrderById(id, orderModel);
            OrderResponseModel orderOutput = _mapper.Map<OrderResponseModel>(newOrder);

            return Ok(orderOutput);
        }
    }
}
