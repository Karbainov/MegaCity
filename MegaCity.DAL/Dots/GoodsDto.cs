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

        public List<ComponentDto> Components { get; set; }

        public List<StorageChangePositionDto> StorageChangePositions { get; set; }

        public GoodsDto(int id, string name, double cost, int count, string unit, List<ComponentDto> components, List<StorageChangePositionDto> storageChangePositions)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Count = count;
            Unit = unit;
            Components = components;
            StorageChangePositions = storageChangePositions;
        }
    }
}
