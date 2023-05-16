using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.RequestModels;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.API.Models.RequestModels;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        GoodsService _goodsService;
        Mapper _mapper;

        public GoodsController()
        {
            _goodsService = new GoodsService();

            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperApiProfile());
            });
            _mapper = new Mapper(configuration);
        }
        [HttpGet]
        public IActionResult GetAllGoods()
        {
            List<GoodsModel> goods = _goodsService.GetAllGoods();
            List<GoodsResponseModel> allGoods = _mapper.Map<List<GoodsResponseModel>>(goods);

            return Ok(allGoods);
        }

        [HttpGet("{id}")]
        public IActionResult GetGoodsById(int id)
        {
            GoodsModel goods = _goodsService.GetGoodsById();
            GoodsResponseModel goodsId = _mapper.Map<GoodsResponseModel>(goods);

            return Ok(goodsId);
        }

        [HttpPost()]
        public IActionResult AddGoods(GoodsRequestModel model)
        {
            GoodsResponseModel goods = new GoodsResponseModel()
            {
                Name = model.Name,
                Price = model.Price,
                Count = model.Count
            };

            return Created("Goods", "NewGoods");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGoodsById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGoodsById(int id, GoodsRequestModel goods)
        {
            GoodsResponseModel modelOutput = new GoodsResponseModel()
            {
                Name = goods.Name,
                Price = goods.Price,
                Count = goods.Count
            };

            return Ok(modelOutput);
        }
    }
}
