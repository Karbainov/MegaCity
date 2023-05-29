using MegaCity.BLL.Models;

namespace MegaCity.API.Models.RequestModels
{
    public class ProductRequestModel
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public List<ComponentRequestModel> Components { get; set; }

        public ProductRequestModel()
        {
            Components = new List<ComponentRequestModel>();
        }
    }
}
