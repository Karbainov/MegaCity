using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;

namespace MegaCity.BLL
{
    public class CashboxService
    {
        public List<CashboxModel> GetAllCashboxes()
        {
            List<CashboxModel> cashboxes = new List<CashboxModel>()
            {
                new CashboxModel()
                {
                    Cash = 20000,
                    Card = 17890
                },

                new CashboxModel()
                {
                    Cash = 20000,
                    Card = 17890
                }
            };

            return cashboxes;
        }

        public CashboxModel GetCashboxById()
        {

            CashboxModel cashbox = new CashboxModel()
            {
                Cash = 20000,
                Card = 17890
            };

            return cashbox;
        }
    }
}
