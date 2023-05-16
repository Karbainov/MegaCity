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
            List<GoodsResponseModel> Goods = _mapper.Map<List<GoodsResponseModel>>(goods);
            return Ok(Goods);
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
            GoodsModel newGoods = _goodsService.AddGoods(productId, goodsModel);
            GoodsResponseModel result = _mapper.Map<GoodsResponseModel>(newGoods);
            return Created(new Uri($"goods/{productId}", UriKind.Relative), result);
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
            GoodsModel newGoods = _goodsService.UpdateGoods(goodsModel);
            GoodsResponseModel result = _mapper.Map<GoodsResponseModel>(newGoods);
            return Ok(result);
        }
    }
}
