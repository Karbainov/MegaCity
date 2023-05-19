using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class WriteOffModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public string DataWriteOff { get; set; }

        public string ReasonWriteOff { get; set; }
    }
}
