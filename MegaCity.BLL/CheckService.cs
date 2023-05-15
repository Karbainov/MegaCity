using MegaCity.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.BLL
{
    public class CheckService
    {
        public List<CheckModel> GetAllChecks()
        {
            List<CheckModel> check_models = new List<CheckModel>()
            {
                new CheckModel()
                {
                    Sum = 171
                },

                new CheckModel()
                {
                    Sum = 187.50
                },
            };
            return check_models;
        }
    }
}
