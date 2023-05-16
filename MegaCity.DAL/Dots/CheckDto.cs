using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
   public class CheckDto
    {
        public int Id { get; set; }

        public double Sum { get; set; }

        public List<ProductDto> Products { get; set; }
    }
}
