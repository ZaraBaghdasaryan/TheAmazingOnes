using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Common.Classes
{
    public class Delivery
    {
        [Key]
        public int Delivery_Id { get; set; }

        [MaxLength(150)]
        public string OK { get; set; }
        [MaxLength(150)]
        public string DeliveryProblem { get; set; }
        
    }
}
  