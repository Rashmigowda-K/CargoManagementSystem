using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoManagementSystem.BAL.Services;
using CargoManagementSystem.Entity.Models;

namespace CargoManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoManagementController : ControllerBase
    {
        private CargoService _cargoServices;
        public CargoManagementController(CargoService cargoServices)
        {
            _cargoServices = cargoServices;
        }
        [HttpGet("GetCustomerDetails")]
        public IEnumerable<CustomerDetails> GetCustomerDetails()
        {
            return _cargoServices.GetCustomerDetails();
        }
        [HttpPost("AddCustomerDetails")]
       public IActionResult AddCustomerDetails([FromBody]CustomerDetails customer)
        {
            _cargoServices.Addcustdetails(customer);
            return Ok("Successfully Added Customer Details");
        }
        [HttpDelete("DeleteCustomerDetails")]
        public IActionResult DeleteCustomerDetails( int custId)
        {
            _cargoServices.Deletecustdetails(custId);
            return Ok("Successfully Delete Customer Details");
        }
    }
}
