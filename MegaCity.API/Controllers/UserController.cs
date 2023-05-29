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
        public IActionResult GetAllUsers()
        {
            List<UserModel> users = _userService.GetAllUsersByRole();
            List<UserResponseModel> allUsers= _mapper.Map<List<UserResponseModel>>(users);

            return Ok(allUsers);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            UserModel user = _userService.GetUserById();
            UserResponseModel adminId = _mapper.Map<UserResponseModel>(user);

            return Ok(adminId);
        }

        [HttpPost()]
        public IActionResult AddUser(UserRequestModel user)
        {
            UserModel userModel = _mapper.Map<UserModel>(user);
            UserModel newUser = _userService.AddUser(userModel);
            UserResponseModel result = _mapper.Map<UserResponseModel>(newUser);

            return Created(new Uri("Admin", UriKind.Relative), result);
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
            _userService.UpdateUserById(id, userModel);
            UserResponseModel userOutput = _mapper.Map<UserResponseModel>(userModel);

            return Ok(userOutput);
        }
    }
}
