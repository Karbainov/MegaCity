using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class AdminDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Date { get; set; }

        public int Age { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<ManagerDto> managerDtos { get; set; }

        public List<ProductDto> productDtos { get; set; }

        public List<GoodsDto> goodsDtos { get; set; }

        public List<FilialDto> filialDtos { get; set; }

        public List<CashboxDto> cashboxDtos { get; set; }

        public List<PromotionDto> promotionDtos { get; set; }

        public List<SpoiledProductsAndGoodsDto> spoiledProductsAndGoodsDtos { get; set; }

        public List<StatisticsDto> statisticsDtos { get; set; }
    }
}
