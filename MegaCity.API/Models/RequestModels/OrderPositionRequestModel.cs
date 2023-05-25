using MegaCity.DAL.Dots;

namespace MegaCity.API.Models.RequestModels
{
    public class OrderPositionRequestModel
    {
        public int Count { get; set; }

        public int ProductId { get; set; }
    }
}
