using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class StorageChangeDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Type { get; set; } //Supply or WriteOff

        public UserDto User { get; set; }

        public List<GoodsDto> Goods { get; set; }
        public StorageChangeDto(int id, DateTime date, string type, UserDto user, List<GoodsDto> goods)
        {
            Id = id;
            Date = date;
            Type = type;
            User = user;
            Goods = goods;
        }
    }
}
