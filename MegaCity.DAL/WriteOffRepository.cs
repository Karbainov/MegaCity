using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class WriteOffRepository
    {
        private MegaCityDbContext _context;

        public WriteOffRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllWriteOff()
        {
            _context.StorageChanges.ToList();
        }

        public StorageChangeDto AddWriteOff(StorageChangeDto supply)
        {
            _context.StorageChanges.Add(supply);
            _context.SaveChanges();

            return supply;
        }

        public void DeleteWriteOffById(int id)
        {
            var supply = _context.StorageChanges.FirstOrDefault(i => i.Id == id);
            if (supply != null)
            {
                _context.StorageChanges.Remove(supply);
                _context.SaveChanges();
            }
        }
    }
}
