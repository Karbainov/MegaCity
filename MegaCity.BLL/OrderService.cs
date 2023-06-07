using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MegaCity.BLL.Models;
using MegaCity.DAL;
using MegaCity.DAL.Dots;

namespace MegaCity.BLL
{
    public class OrderService
    {
        private IMapper _mapper;
        private OrderRepository _orderRepository;

        public OrderService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _orderRepository = new OrderRepository();
        }

        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orders = new List<OrderModel>();
            return orders;
        }

        public OrderModel GetOrderById()
        {
            OrderModel order = new OrderModel();
            return order;
        }

        public OrderModel AddOrder(int userId, List<OrderPositionModel> orderPositions)
        {
            OrderDto orderDto = new OrderDto()
            {
                Date = DateTime.Now,
            };

            var newOrderDto = _orderRepository.AddOrder(userId, orderDto);

            if (newOrderDto != null)
            {
                foreach (var position in orderPositions)
                {
                    _orderRepository.AddOrderPositions(position.Count, position.ProductId, newOrderDto.Id);
                }

                OrderModel newOrder = _mapper.Map<OrderModel>(newOrderDto);

                return newOrder;
            }
            else
            {
                throw new Exception("Ошибка!!!");
            }
        }

        public void DeleteOrderById(int id)
        {
            _orderRepository.DeleteOrderById(id);
        }

        public void UpdateOrderById(int id, OrderModel order)
        {
            OrderModel orderOutput = new OrderModel();
            {
                string Name = order.Name;
                int Number = order.Number;
            };
        }
    }
}
