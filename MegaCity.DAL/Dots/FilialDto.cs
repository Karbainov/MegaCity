using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class FilialDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public AdminDto Admin { get; set; }

        public List<ManagerDto> Managers { get; set; }

        public CashboxDto Cashbox { get; set; }

        public List<ProductDto> Products { get; set; }

        public List<GoodsDto> Goods { get; set; }

        public List<SpoiledProductsAndGoodsDto> SpoiledProductsAndGoods { get; set; }

        public List<OrderDto> Orders { get; set; }

        public List<PromotionDto> Promotions { get; set; }
    }
}
