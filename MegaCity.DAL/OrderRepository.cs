using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class OrderRepository
    {
        private MegaCityDbContext _context;

        public OrderRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllOrders()
        {
            _context.Orders.ToList();
        }

        public OrderDto GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(i => i.Id == id);
        }

        public void AddOrder(OrderDto order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
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
