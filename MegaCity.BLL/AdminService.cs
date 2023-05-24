﻿using System;
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

        public List<AdminModel> GetAllAdmins()
        {
            List<AdminModel> admins = new List<AdminModel>();
            return admins;
        }

        public AdminModel GetAdminById()
        {
            AdminModel admin = new AdminModel();

            return admin;
        }

        public AdminModel AddAdmin(AdminModel admin)
        {
            UserDto adminDto = new UserDto();

            var adminUser = _adminRepository.AddAdmin(adminDto);

            if (adminUser != null)
            {
                AdminModel newAdminUser = _mapper.Map<AdminModel>(adminUser);

                return newAdminUser;
            }
            else
            {
                throw new Exception("Админ не создан!");
            }
        }

        public void UpdateAdminById(int id, AdminModel admin)
        {
            AdminModel adminOutput = new AdminModel()
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
