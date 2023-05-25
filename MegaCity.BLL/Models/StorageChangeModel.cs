using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class StorageChangeModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Type { get; set; }

        public UserDto User { get; set; }

        public List<GoodsModel> Goods { get; set; }

        public StorageChangePositionModel StorageChangePosition { get; set; }

        public StorageChangeModel()
        {
            Goods = new List<GoodsModel>();
        }
    }
}
