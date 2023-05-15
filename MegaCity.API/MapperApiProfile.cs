using AutoMapper;
using MegaCity.API.Models;
using MegaCity.BLL.Models;
using MegaCity.BLL;
using MegaCity.API.Models.ResponseModel;

namespace MegaCity.API;

public class MapperApiProfile : Profile
{
    public MapperApiProfile()
    {
        CreateMap<ProductModel,ProductResponseModel>();
        CreateMap<AdminModel, AdminResponseModel>();
        CreateMap<ManagerModel, ManagerResponseModel>();
        CreateMap<SpoiledProductsAndGoodsModel, SpoiledProductsAndGoodsResponseModel>();
        CreateMap<GoodsModel, GoodsResponseModel>();
    }

}
