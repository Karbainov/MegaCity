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
            return _mapper.Map<List<UserModel>>(_userRepository.GetAllUsersByRole(role));
        }

        public UserModel GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);

            return _mapper.Map<UserModel>(user);
        }

        public UserModel AddUser(UserModel user)
        {
            var newUser = _mapper.Map<UserDto>(user);

            return _mapper.Map<UserModel>(_userRepository.AddUser(newUser));
        }

        public UserModel UpdateUserById(int id, UserModel user)
        {
            var updateUser = _mapper.Map<UserDto>(user);

            return _mapper.Map<UserModel>(_userRepository.UpdateUserById(id, updateUser));
        }

        public void DeleteUserById(int id)
        {
            _userRepository.DeleteUserById(id);
        }
    }
}
