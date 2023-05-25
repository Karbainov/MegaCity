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

        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public int ProductCount { get; set; }

        public List<ProductModel> Products { get; set; }

        public OrderPositionModel()
        {
            Products = new List<ProductModel>();
        }
    }
}
