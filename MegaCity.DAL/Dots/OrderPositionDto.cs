﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class OrderPositionDto
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public ProductDto Product { get; set; }

        public OrderDto Order { get; set; }
    }
}
