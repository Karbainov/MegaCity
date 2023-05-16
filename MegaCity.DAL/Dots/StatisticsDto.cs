using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class StatisticsDto
    {
        public int Id { get; set; }

        public double Profit { get; set; }

        public double Cost { get; set; }

        public double ExcessProducts { get; set; }

        public double ExcessGoods { get; set; }

        public double ProductDeficit { get; set; }

        public double GoodsDeficit { get; set; }
    }
}
