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
       private GoodsService _goodsService;
       private IMapper _mapper;

        public GoodsController()
        {
            _goodsService = new GoodsService();
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile())));
            
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
            var goods = _mapper.Map<GoodsResponseModel>(_goodsService.GetGoodsById(id));

            return Ok(goods);
        }

        [HttpPost("{Id}")]
        public IActionResult AddGoods(int productId,GoodsRequestModel model)
        {
            GoodsModel goodsModel = _mapper.Map<GoodsModel>(model);
            _goodsService.AddGoods(goodsModel);
            GoodsResponseModel newGoods = _mapper.Map<GoodsResponseModel>(goodsModel);

            return Created(new Uri("Goods", UriKind.Relative), newGoods);
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

            return Ok(goodsOutput);
        }
    }
}
