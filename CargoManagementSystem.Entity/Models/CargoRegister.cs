using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagementSystem.Entity.Models
{
    public class CargoRegister
    {
        
        public string CustName { get; set; }
        [Key]
        public string CustMailId { get; set; }
        public int MobilNum { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }



    }
}
