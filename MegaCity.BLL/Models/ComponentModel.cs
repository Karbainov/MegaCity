using MegaCity.DAL.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL.Models
{
    public class ComponentModel
    {
        public int Id { get; set; }

        public double Count { get; set; }

        public int  GoodsId { get; set; }

        public int ProductId { get; set; }

        public GoodsModel Goods { get; set; }

        public ProductModel Product { get; set; }
    }
}
