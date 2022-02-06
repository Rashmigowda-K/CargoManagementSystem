using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagementSystem.Entity.Models
{
    public class CustomerDetails
    {
        public string CustName { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustId { get; set; }
        public string CustAddress { get; set; }
        public string CustCity { get; set; }
        public int CustPincode { get; set; }
        public int CustPhoneNum { get; set; }
        public string ReceiverName { get; set; }
        public int ReceiverId { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceivertCity { get; set; }
        public int ReceiverPincode { get; set; }
        public int ReceiverPhoneNum { get; set; }
    }
}
