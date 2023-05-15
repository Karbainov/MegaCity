﻿using AutoMapper;
using MegaCity.API.Models.RequestModel;
using MegaCity.API.Models.ResponseModel;
using MegaCity.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MegaCity.BLL;
using MegaCity.BLL.Models;
using AutoMapper;
using MegaCity.API.Models.RequestModels;


namespace MegaCity.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        ManagerService _managerService;
        Mapper _mapper;

        public ManagerController()
        {
            _managerService = new ManagerService();
            MapperConfiguration configuration = new MapperConfiguration(cfg => cfg.AddProfile(new MapperApiProfile()));
            _mapper = new Mapper(configuration);
        }

        [HttpGet]
        public IActionResult GetAllManagers()
        {
            List<ManagerModel> managers = _managerService.GetAllManagers();

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetManagerById(int id)
        {
            ManagerResponseModel manager = new ManagerResponseModel()
            {
                Id = 9,
                FirstName = "FirstName",
                LastName = "LastName",
                Age = 150,
                PhoneNumber = 123451
            };

            return Ok(manager);
        }

        [HttpPost()]
        public IActionResult AddManager(ManagerRequestModel manager)
        {
            ManagerResponseModel addManager = new ManagerResponseModel()
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName
            };

            return Created("Manager", "NewManager");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteManagerById(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateManagerById(int id, ManagerRequestModel manager)
        {
            ManagerResponseModel managerOutput = new ManagerResponseModel()
            {
                FirstName = manager.FirstName,
                LastName = manager.LastName,
                PhoneNumber = manager.PhoneNumber,
                Email = manager.Email
            };

            return Ok(managerOutput);
        }
    }
}
