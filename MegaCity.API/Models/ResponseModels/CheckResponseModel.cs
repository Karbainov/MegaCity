﻿namespace MegaCity.API.Models.ModelsOutput
{
    public class CheckResponseModel
    {
        public string Id { get; set; }

        public double Sum { get; set; }

        public List<ProductResponseModel> Products { get; set; }
    }
}
