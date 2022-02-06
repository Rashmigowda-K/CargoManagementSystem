using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CargoManagementSystem.Entity.Models
{
    public class Billing
    {
        [Key]
        public int BillNo { get; set; }
        public int CustId { get; set; }
        public int CustAddress { get; set; }

        

    }
}
