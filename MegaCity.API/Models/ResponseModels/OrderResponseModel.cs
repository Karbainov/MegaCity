using MegaCity.API.Models.RequestModels;

namespace MegaCity.API.Models.ResponseModel
{
    public class OrderResponseModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public List<OrderPositionRequestModel> Positions { get; set; }
    }
}
