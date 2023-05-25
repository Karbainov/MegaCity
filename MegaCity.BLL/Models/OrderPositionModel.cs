using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class OrderPositionModel
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public int ProductId { get; set; }

        public ProductDto Product { get; set; }

        public OrderDto Order { get; set; }
    }
}
