using AutoMapper;
using MegaCity.API.Models;
using MegaCity.BLL.Models;
using MegaCity.BLL;
using MegaCity.API.Models.ModelsOutput;

namespace MegaCity.API;

public class MapperApiProfile : Profile
{
    public MapperApiProfile()
    {
        CreateMap<ProductModel,ProductResponseModel>();
    }

}
