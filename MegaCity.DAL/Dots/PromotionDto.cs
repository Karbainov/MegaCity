﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class PromotionDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public string Description { get; set; }
    }
}
