using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public List<ComponentModel> Components { get; set; }

        public List<OrderPositionModel> Positions { get; set; }

        public ProductModel()
        {
            Components = new List<ComponentModel>();
            Positions = new List<OrderPositionModel>();
        }
    }
}
