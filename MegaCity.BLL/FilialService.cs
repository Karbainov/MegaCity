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
    public class FilialService
    {
        private IMapper _mapper;
        private FilialRepository _filialRepository;

        public FilialService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _filialRepository = new FilialRepository();
        }

        public List<FilialModel> GetAllFilials()
        {
            List<FilialModel> filials = new List<FilialModel>()
            {
                new FilialModel()
                {
                    Name = "FilialOne",
                    Adress="Nizami str.68"
                },

                new FilialModel()
                {
                    Name = "FilialTwo",
                    Adress = "Yasamal str.76"
                }
            };

            return filials;
        }

        public FilialModel GetFilialById()
        {
            FilialModel filial = new FilialModel();
            {
                string Adress = "Heydar A.str.str.10";
            };

            return filial;
        }

        public void AddFilial(FilialModel filial)
        {
            FilialModel filialModel = new FilialModel
            {
                Name = filial.Name,
                Adress = filial.Adress
            };
        }

        public void UpdateFilialById(int id, FilialModel filial)
        {
            FilialModel filialOutput = new FilialModel
            {
                Name = filial.Name,
                Adress = filial.Adress
            };
        }

        public void DeleteFilialById(int id)
        {
            _filialRepository.DeleteFilialById(id);
        }
    }
}
