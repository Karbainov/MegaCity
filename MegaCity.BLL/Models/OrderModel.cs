using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class OrderModel
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        public List<OrderPositionModel> Positions { get; set; }

        public OrderModel()
        {
            Positions = new List<OrderPositionModel>();
        }
    }
}
