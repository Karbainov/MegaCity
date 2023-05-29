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
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile())));
            
        }
        
        [HttpGet("{id}")]
        public IActionResult GetGoodsById(int id)
        {
            var a = _goodsService.GetGoodsById();
            var goods = _mapper.Map<GoodsResponseModel>(a);

            return Ok(goods);
        }

        [HttpPost("{Id}")]
        public IActionResult AddGoods(GoodsRequestModel goods)
        {
            GoodsModel goodsModel = _mapper.Map<GoodsModel>(goods);
            GoodsModel newGoods = _goodsService.AddGoods(goodsModel);
            GoodsResponseModel result = _mapper.Map<GoodsResponseModel>(newGoods);

            return Created(new Uri($"Goods", UriKind.Relative), result);
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
            goodsModel.Id = id;
            GoodsModel newGoods = _goodsService.UpdateGoodsById(goodsModel);
            GoodsResponseModel goodsOutput = _mapper.Map<GoodsResponseModel>(newGoods);

            return Ok(goods);
        }
    }
}
