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
    public class UserService
    {
        private IMapper _mapper;
        private UserRepository _userRepository;

        public UserService()
        {
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile(new MapperBLLProfile())));
            _userRepository = new UserRepository();
        }

        public List<UserModel> GetAllUsersByRole(string role)
        {
            List<UserModel> users = new List<UserModel>();

            return users;
        }

        public UserModel GetUserById()
        {
            UserModel user = new UserModel();

            return user;
        }

        public UserModel AddUser(UserModel userModel)
        {
            var user = _mapper.Map<UserDto>(userModel);

            return _mapper.Map<UserModel>(_userRepository.AddUser(user));
        }

        public void UpdateUserById(int id, UserModel user)
        {
            UserModel userOutput = new UserModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public void DeleteUserById(int id)
        {
            _userRepository.DeleteUserById(id);
        }
    }
}
