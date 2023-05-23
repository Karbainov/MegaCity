using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class SupplyRepository
    {
        private MegaCityDbContext _context;

        public SupplyRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllSupply()
        {
            _context.StorageChanges.ToList();
        }

        public void AddSupply(StorageChangeDto supply)
        {
            _context.StorageChanges.Add(supply);
            _context.SaveChanges();
        }

        public void DeleteSupplyById(int id)
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
