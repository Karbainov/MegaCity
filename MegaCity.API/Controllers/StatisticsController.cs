using MegaCity.API.Models.ModelsOutput;
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
            StatisticsOutputModel dayStatistics = new StatisticsOutputModel()
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
            StatisticsOutputModel weekStatistics = new StatisticsOutputModel()
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
            StatisticsOutputModel monthStatistics = new StatisticsOutputModel()
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
            StatisticsOutputModel yearStatistics = new StatisticsOutputModel()
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
