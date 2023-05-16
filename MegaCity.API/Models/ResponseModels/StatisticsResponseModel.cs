namespace MegaCity.API.Models.ResponseModel
{
    public class StatisticsResponseModel
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
