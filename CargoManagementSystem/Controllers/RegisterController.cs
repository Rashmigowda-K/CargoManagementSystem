using CargoManagementSystem.BAL.Services;
using CargoManagementSystem.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CargoManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private RegisterService _registerService;
        public RegisterController(RegisterService registerService)
        {
            _registerService = registerService;
        }
        [HttpPost("Register")]
        public IActionResult Register([FromBody] CargoRegister cargoRegister)
        {
            _registerService.Register(cargoRegister);
            return Ok("Registered successfully");
        }
        [HttpPost("Login")]
        public IActionResult Login([FromBody] CargoRegister cargologin)
        {
            CargoRegister user = _registerService.Login(cargologin);
            if (user != null)
                return Ok("Login success!!");
            else
                return NotFound();
        }

    }
}
