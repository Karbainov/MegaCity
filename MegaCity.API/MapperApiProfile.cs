using AutoMapper;
using MegaCity.API.Models;
using MegaCity.BLL.Models;
using MegaCity.BLL;
using MegaCity.API.Models.ResponseModel;
using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.RequestModels;

namespace MegaCity.API;

public class MapperApiProfile : Profile
{
    public MapperApiProfile()
    {
        CreateMap<AdminModel, AdminResponseModel>();
        CreateMap<AdminRequestModel, AdminModel>();

        CreateMap<CashboxModel, CashboxResponseModel>();
        CreateMap<CashboxIRequestModel, CashboxModel>();

        CreateMap<CheckModel, CheckResponseModel>();

        CreateMap<FilialModel, FilialResponseModel>();
        CreateMap<FilialRequestModel, FilialModel>();

        CreateMap<GoodsModel, GoodsResponseModel>();
        CreateMap<GoodsRequestModel, GoodsModel>();

        CreateMap<ManagerModel, ManagerResponseModel>();
        CreateMap<ManagerRequestModel, ManagerModel>();

        CreateMap<OrderModel, OrderResponseModel>();

        CreateMap<ProductModel,ProductResponseModel>();
        CreateMap<ProductRequestModel, ProductModel>();

        CreateMap<SpoiledProductsAndGoodsModel, SpoiledProductsAndGoodsResponseModel>();
        CreateMap<SpoiledProductsAndGoodsRequestModel, SpoiledProductsAndGoodsModel>();
    }

}
