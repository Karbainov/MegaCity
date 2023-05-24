using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.RequestModels;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;


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
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
            
        }
        
        [HttpGet("{id}")]
        public IActionResult GetGoodsById(int id)
        {
            var goods = _mapper.Map<GoodsResponseModel>(_goodsService.GetGoodsById(id));

            return Ok(goods);
        }

        [HttpPost("{Id}")]
        public IActionResult AddGoods(GoodsRequestModel model)
        {
            
            GoodsModel goodsModel = _mapper.Map<GoodsModel>(model);
            GoodsModel newGoods = _goodsService.AddGoods(model.Id);
            GoodsResponseModel result = _mapper.Map<GoodsResponseModel>(newGoods);

            return Created(new Uri("Goods", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGoodsById(int id)
        {
            _goodsService.DeleteGoodsById(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGoodsById(int id, GoodsRequestModel goods)
        {
            GoodsModel goodsModel = _mapper.Map<GoodsModel>(goods);
            _goodsService.UpdateGoodsById(id, goodsModel);
            GoodsResponseModel goodsOutput = _mapper.Map<GoodsResponseModel>(goodsModel);

            return Ok(goods);
        }
    }
}
