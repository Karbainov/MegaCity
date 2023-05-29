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

        public List<StorageChangeDto> StorageChanges { get; set; }
    }
}
