﻿using System.Security.Cryptography.X509Certificates;

namespace MegaCity.API.Models.OutputModel
{
    public class StatisticsOutputModel
    {
        public double Profit { get; set; }

        public double Cost { get; set; }

        public double ExcessProducts { get; set; }

        public double ExcessGoods { get; set; }

        public double ProductDeficit { get; set; }

        public double GoodsDeficit { get; set; }
    }
}
