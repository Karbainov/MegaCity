using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class OrderService
    {
        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orders = new List<OrderModel>()
            {
                new OrderModel()
                {
                    Name = "product1",
                    Number = 5
                },

                new OrderModel()
                {
                    Name = "product2",
                    Number = 10
                },

                new OrderModel()
                {
                    Name = "product3",
                    Number = 3
                },

            };

            return orders;
        }

        public OrderModel GetOrderById()
        {

            OrderModel order = new OrderModel()
            {
                Name = "product",
                Number = 5
            };

            return order;
        }
    }
}
