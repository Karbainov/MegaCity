using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        [HttpGet("day")]
        public IActionResult GetDayStatistics()
        {
            StatisticsResponseModel dayStatistics = new StatisticsResponseModel()
            {
                Profit = 27637.3874678,
                Cost = 366487.435,
                ExcessProducts = 0,
                ExcessGoods = 0,
                ProductDeficit = 273,
                GoodsDeficit = 365
            };

            return Ok(dayStatistics);
        }

        [HttpGet("week")]
        public IActionResult GetWeekStatistics()
        {
            StatisticsResponseModel weekStatistics = new StatisticsResponseModel()
            {
                Profit = 357.23894,
                Cost = 4674.4,
                ExcessProducts = 0,
                ExcessGoods = 0,
                ProductDeficit = 7576,
                GoodsDeficit = 4567
            };

            return Ok(weekStatistics);
        }

        [HttpGet("month")]
        public IActionResult GetMonthStatistics()
        {
            StatisticsResponseModel monthStatistics = new StatisticsResponseModel()
            {
                Profit = 488955.547,
                Cost = 4768.46,
                ExcessProducts = 0,
                ExcessGoods = 0,
                ProductDeficit = 6588,
                GoodsDeficit = 5789
            };

            return Ok(monthStatistics);
        }

        [HttpGet("year")]
        public IActionResult GetYearStatistics()
        {
            StatisticsResponseModel yearStatistics = new StatisticsResponseModel()
            {
                Profit = 9489.5,
                Cost = 45609.645,
                ExcessProducts = 0,
                ExcessGoods = 0,
                ProductDeficit = 958,
                GoodsDeficit = 987
            };

            return Ok(yearStatistics);
        }
    }
}
