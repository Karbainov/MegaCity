using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class GoodsDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Cost { get; set; }

        public int Count { get; set; }

        public string Unit { get; set; }

        public DateTime Date { get; set; }

        public List<ComponentDto> Components { get; set; }

        public List<StorageChangePositionDto> StorageChangePositions { get; set; }

        public GoodsDto()
        {
            Components = new List<ComponentDto>();
            StorageChangePositions = new List<StorageChangePositionDto>();
        }
    }
}
