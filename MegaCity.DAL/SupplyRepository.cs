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

        public StorageChangeDto GetSupplyById(int id)
        {
            return _context.StorageChanges.FirstOrDefault(i => i.Id == id);
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

        public StorageChangeDto UpdateSupplyById(int id,StorageChangeDto supply)
        {
            var supplyId = _context.StorageChanges.FirstOrDefault(i => i.Id == supply.Id);

            if(supplyId!=null)
            {
                supplyId.Date = DateTime.Now;
                supplyId.Type = supply.Type;
                supplyId.User = supply.User;

                _context.SaveChanges();

                return supplyId;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
