using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class StorageChangePositionModel
    {
        public int Id { get; set; }

        public double Count { get; set; }

        public GoodsDto Goods { get; set; }

        public StorageChangeDto StorageChange { get; set; }
    }
}
