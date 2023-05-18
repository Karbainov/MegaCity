using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class StorageChangePositionDto
    {
        public int Id { get; set; }

        public double Count { get; set; }

        public GoodsDto Goods { get; set; }

        public StorageChangeDto StorageChange { get; set; }
        public StorageChangePositionDto(int id, double count, GoodsDto goods, StorageChangeDto storageChange)
        {
            Id = id;
            Count = count;
            Goods = goods;
            StorageChange = storageChange;
        }
    }
}
