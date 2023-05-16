using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        PromotionService _promotionService;
        Mapper _mapper;

        public PromotionController()
        {
            _promotionService = new PromotionService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllPromotions()
        {
            List<PromotionModel> promotions = _promotionService.GetAllPromotions();
            List<PromotionResponseModel> allPromotions = _mapper.Map<List<PromotionResponseModel>>(promotions);

            return Ok(allPromotions);
        }

        [HttpGet("{id}")]
        public IActionResult GetPromotionById(int id)
        {
            PromotionModel promotion = _promotionService.GetPromotionById();

            return Ok(promotion);
        }

        [HttpPost]
        public IActionResult AddPromotion(PromotionRequestModel promotion)
        {
            PromotionModel promotionModel = _mapper.Map<PromotionModel>(promotion);
            _promotionService.AddPromotion(promotionModel);

            PromotionResponseModel newPromotion = _mapper.Map<PromotionResponseModel>(promotionModel);

            return Created(new Uri("Promotion", UriKind.Relative), newPromotion);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePromotionById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePromotionById(int id, PromotionRequestModel promotion)
        {
            PromotionModel promotionModel = _mapper.Map<PromotionModel>(promotion);
            _promotionService.UpdatePromotionById(id, promotionModel);

            PromotionResponseModel promotionOutput = _mapper.Map<PromotionResponseModel>(promotionModel);

            return Ok(promotionOutput);
        }
    }
}
