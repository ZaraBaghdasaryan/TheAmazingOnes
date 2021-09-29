using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Common.Classes
{
    public class SQLMO
    {
        [Key]
        public int SQLMO_Id { get; set; }

        [MaxLength(150), Required]
        public string Safety { get; set; }

        [MaxLength(150), Required]
        public string Delivery { get; set; }

        [MaxLength(150), Required]
        public string Material { get; set; }

        [MaxLength(150), Required]
        public string Tidy { get; set; }

        [MaxLength(150), Required]
        public string Quality { get; set; }
    }
}

