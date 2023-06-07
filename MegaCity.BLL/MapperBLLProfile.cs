using AutoMapper;
using MegaCity.BLL.Models;
using MegaCity.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;
using Microsoft.EntityFrameworkCore;

namespace MegaCity.BLL
{
    public class MapperBLLProfile:Profile
    {
        public MapperBLLProfile()
        {
            CreateMap<GoodsModel, GoodsDto>().ReverseMap();

            CreateMap<ProductModel, ProductDto>().ReverseMap();
            CreateMap<ComponentModel, ComponentDto>().ReverseMap();

            CreateMap<UserModel, UserDto>().ReverseMap();

            CreateMap<OrderModel, OrderDto>().ReverseMap();
            CreateMap<OrderPositionModel, OrderPositionDto>().ReverseMap();

            CreateMap<StorageChangeModel, StorageChangeDto>().ReverseMap();
            CreateMap<StorageChangePositionModel, StorageChangePositionDto>().ReverseMap();
        }
    }
}
