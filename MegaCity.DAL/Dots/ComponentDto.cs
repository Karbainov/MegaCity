﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class ComponentDto
    {
        public int Id { get; set; }

        public double Count { get; set; }

        public GoodsDto Goods { get; set; }

        public ProductDto Product { get; set; }
    }
}
