using CargoManagementSystem.Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoManagementSystem.BAL.Services;

namespace CargoManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransController : ControllerBase
    {
        private TransService _transservice;
        public TransController(TransService transservice)
        {
            _transservice = transservice;
        }
        [HttpGet("GetTranscationDetails")]
        public IEnumerable<Transaction> GetTranscationDetails()
        {
            return _transservice.GetTransactionDetails();
        }
        [HttpPost("AddTranscationDetails")]
        public IActionResult AddTranscation_details([FromBody] Transaction transaction)
        {
            _transservice.AddTransactionDetails(transaction);
            return Ok("Successfully added Transaction Details");
        }
        [HttpDelete("DeleteTranscation_details")]
        public IActionResult DeleteTranscation_details(int Bill_no)
        {
            _transservice.DeleteTransactionDetails(Bill_no);
            return Ok("Successfully deleted Transaction Details");
        }
        [HttpPut("UpdateTranscation_details")]
        public IActionResult UpdateTranscation_details(Transaction transaction)
        {
            _transservice.UpdateTransationDetails(transaction);
            return Ok("Transaction details updated successfully!!");
        }
        [HttpGet("GetTranscationDetailsbyno")]
        public void GetTranscationDetailsbyno(int Bill_no)
        {
            _transservice.GetTransactionDetailsbyid(Bill_no);

        }
    }
}
