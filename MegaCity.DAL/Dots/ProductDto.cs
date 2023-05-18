using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public List<ComponentDto> Components { get; set; }

        public List<OrderPositionDto> Positions { get; set; }

        public ProductDto() 
        { 
            Components = new List<ComponentDto>();
            Positions = new List<OrderPositionDto>();
        }
    }
}
