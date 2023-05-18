using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
   public class OrderDto
    {
        public int Id { get; set; }

        public double Sum { get; set; }

        public DateTime Date { get; set; }

        public List<OrderPositionDto> Positions { get; set; }

        public UserDto User { get; set; }

        public OrderDto()
        {
            Positions = new List<OrderPositionDto>();
        }
    }
}
