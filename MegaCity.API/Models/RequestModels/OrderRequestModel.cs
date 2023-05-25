using MegaCity.API.Models.RequestModels;

namespace MegaCity.API.Models.RequestModel
{
    public class OrderRequestModel
    {
        public int UserId { get; set; }

        public List<OrderPositionRequestModel> Positions { get; set; }
    }
}
