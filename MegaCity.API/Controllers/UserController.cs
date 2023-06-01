using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;

namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService _userService;
        Mapper _mapper;

        public UserController()
        {
            _userService = new UserService();
            MapperConfiguration configuration  = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllUsers(string role)
        {
            var users = _mapper.Map<List<UserResponseModel>>(_userService.GetAllUsersByRole(role));

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            var userId = _mapper.Map<UserResponseModel>(user);

            return Ok(userId);
        }

        [HttpPost()]
        public IActionResult AddUser(UserRequestModel user)
        {
            UserModel userModel = _mapper.Map<UserModel>(user);
            UserModel newUser = _userService.AddUser(userModel);
            UserResponseModel result = _mapper.Map<UserResponseModel>(newUser);

            return Created(new Uri("User", UriKind.Relative), result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUserById(int id)
        {
            _userService.DeleteUserById(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUserById(int id, UserRequestModel user)
        {
            UserModel userModel = _mapper.Map<UserModel>(user);
            userModel.Id = id;
            UserModel newUser = _userService.UpdateUserById(id, userModel);
            UserResponseModel userOutput = _mapper.Map<UserResponseModel>(userModel);

            return Ok(userOutput);
        }
    }
}
