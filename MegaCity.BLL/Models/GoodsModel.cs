using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class GoodsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Cost { get; set; }

        public int Count { get; set; }

        public string Unit { get; set; }

        public DateTime Date { get; set; }

        public List<ComponentModel> Components { get; set; }

        public List<StorageChangePositionModel> StorageChangePositions { get; set; }

        public GoodsModel()
        {
            Components = new List<ComponentModel>();
            StorageChangePositions = new List<StorageChangePositionModel>();
        }
    }
}
