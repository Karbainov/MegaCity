using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class StatisticsRepository
    {
        private MegaCityDbContext _context;

        public StatisticsRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllStatistics()
        {
            _context.Statistics.ToList();
        }

        public void DeleteStatistics(int id)
        {
            var statistics = _context.Statistics.FirstOrDefault(i => i.Id == id);
            if (statistics != null)
            {
                _context.Statistics.Remove(statistics);
                _context.SaveChanges();
            }
        }
    }
}
