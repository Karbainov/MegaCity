using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MegaCity.BLL.Models;
using MegaCity.DAL;

namespace MegaCity.BLL
{
    public class CashboxService
    {
        private IMapper _mapper;
        private CashboxRepository _cashboxRepository;

        public CashboxService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _cashboxRepository = new CashboxRepository();
        }

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

        public void AddCashbox(CashboxModel cashbox)
        {
            CashboxModel addCashbox = new CashboxModel()
            {
                Cash = cashbox.Cash,
                Card = cashbox.Card
            };
        }

        public void UpdateCashboxById(int id, CashboxModel cashbox)
        {
            CashboxModel cashboxOutput = new CashboxModel()
            {
                Cash = cashbox.Cash,
                Card = cashbox.Card
            };
        }

        public void DeleteCashboxById(int id)
        {
            _cashboxRepository.DeleteById(id);
        }
    }
}
