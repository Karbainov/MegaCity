using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

namespace MegaCity.DAL
{
    public class OrderRepository
    {
        private MegaCityDbContext _context;

        public OrderRepository()
        {
            _context = new MegaCityDbContext();
        }

        public List<OrderDto> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public OrderDto GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(i => i.Id == id);
        }

        public OrderDto AddOrder(int userId, OrderDto order)
        {
            var user = _context.Orders.FirstOrDefault(i => i.Id == order.Id);

            if (user != null && order != null)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();

                return user;
            }
            else
            {
                throw new Exception();
            }
            
        }

        public OrderPositionDto AddOrderPositions(int count, int productId, int orderId)
        {
            var product = _context.Products.FirstOrDefault(i => i.Id == productId);
            var order = _context.Orders.FirstOrDefault(i => i.Id == orderId);

            if (product != null && order != null)
            {
                OrderPositionDto newOrderPosition = new OrderPositionDto()
                {
                    Count = count,
                    Product = product,
                    Order = order
                };
                _context.OrderPositions.Add(newOrderPosition);

                product.Positions.Add(newOrderPosition);
                order.Positions.Add(newOrderPosition);

                _context.SaveChanges();

                return newOrderPosition;
            }
            else 
            {
                throw new Exception("Такой продукт или заказ не существует!");
            }
        }

        public void DeleteOrderById(int id)
        {
            var order = _context.Orders.FirstOrDefault(i => i.Id == id);

            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
