using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CargoManagementSystem.Entity.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BillNo { get; set; }
        [Required]
        [ForeignKey("CustId")]
        public int SenderId { get; set; }
      
        public virtual CustomerDetails CustId { get; set; }
        [Required]
        public string TypeOfGoods { get; set; }
        [Required]
        public int GoodsQty { get; set; }
        [Required]
        public int TransAmount { get; set; }
        [Required]
        public string SendingDate { get; set; }
        [Required]
        public string ReceiverDate { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
    }
}
