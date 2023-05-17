using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.DAL.Dots;

namespace MegaCity.DAL
{
    public class FilialRepository
    {
        private MegaCityDbContext _context;

        public FilialRepository()
        {
            _context = new MegaCityDbContext();
        }

        public void GetAllFilials()
        {
            _context.Filials.ToList();
        }

        public FilialDto GetFilialById(int id)
        {
            return _context.Filials.FirstOrDefault(i => i.Id == id);
        }

        public void AddFilial(FilialDto filial)
        {
            _context.Filials.Add(filial);
            _context.SaveChanges();
        }

        public void DeleteFilialById(int id)
        {
            var filial = _context.Filials.FirstOrDefault(i => i.Id == id);
            if (filial != null)
            {
                _context.Filials.Remove(filial);
                _context.SaveChanges();
            }
        }
    }
}
