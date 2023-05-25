using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCity.BLL.Models;
using MegaCity.DAL;
using MegaCity.DAL.Dots;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MegaCity.BLL
{
    public class AdminService
    {
        private IMapper _mapper;
        private AdminRepository _adminRepository;

        public AdminService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _adminRepository = new AdminRepository();
        }

        //public string AdminService.Insert (int StartIndex, string User);

        public string admin = "INSERT INTO dbo.SMS_PW(Id, FirstName, LastName, Date, PhoneNumber, Email) VALUES(@id, @firstName, @lastName, @date, @phoneNumber, @email)";
        //SqlCommand command = new SqlCommand(admin, db.Connection);

        public List<UserModel> GetAllAdmins()
        {
            List<UserModel> admins = new List<UserModel>();
            return admins;
        }

        public UserModel GetAdminById()
        {
            UserModel admin = new UserModel();

            return admin;
        }

        public UserModel AddAdmin(int userId,UserModel adminModel)
        {
            var model = _mapper.Map<UserDto>(adminModel);
            return _mapper.Map<UserModel>(_adminRepository.AddAdmin(userId, model));
        }

        public void UpdateAdminById(int id, UserModel admin)
        {
            UserModel adminOutput = new UserModel()
            {
                FirstName = admin.FirstName,
                LastName = admin.LastName
            };
        }

        public void DeleteAdminById(int id)
        {
            _adminRepository.DeleteById(id);
        }
    }
}
