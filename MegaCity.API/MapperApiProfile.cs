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
        CreateMap<UserModel, UserResponseModel>();
        CreateMap<UserRequestModel, UserModel>();

        CreateMap<GoodsModel, GoodsResponseModel>();
        CreateMap<GoodsRequestModel, GoodsModel>();

        CreateMap<ManagerModel, ManagerResponseModel>();
        CreateMap<ManagerRequestModel, ManagerModel>();

        CreateMap<OrderModel, OrderResponseModel>();
        CreateMap<OrderRequestModel, OrderModel>();

        CreateMap<OrderPositionRequestModel, OrderPositionModel>();

        CreateMap<ProductModel,ProductResponseModel>();
        CreateMap<ProductRequestModel, ProductModel>();

        CreateMap<StorageChangeModel, StorageChangeResponseModel>();
        CreateMap<StorageChangeRequestModel, StorageChangeModel>();
    }

}
