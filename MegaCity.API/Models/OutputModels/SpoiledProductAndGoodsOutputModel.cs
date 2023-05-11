﻿namespace MegaCity.API.Models.OutputModel
{
    public class SpoiledProductAndGoodsOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public string DataWriteOff { get; set; }

        public string ReasonWriteOff { get; set; }
    }
}
