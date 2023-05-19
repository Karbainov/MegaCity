using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Models.RequestModels
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckRequestModel : ControllerBase
    {
        public double Sum { get; set; }

        public List<ProductResponseModel> Products { get; set; }
    }
}
