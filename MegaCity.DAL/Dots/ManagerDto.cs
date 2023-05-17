using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class ManagerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Date { get; set; }

        public int Age { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<GoodsDto> goodsDtos { get; set; }

        public CashboxDto CashboxDto { get; set; }

        public CheckDto CheckDto { get; set; }

        public List<OrderDto> orderDtos { get; set; }

        public List<PromotionDto> promotionDtos { get; set; }
    }
}
