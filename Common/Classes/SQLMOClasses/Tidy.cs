using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Common.Classes
{
    public class Tidy
    {
        [Key]
        public int Tidy_Id { get; set; }

        [MaxLength(150)]
        public string OK { get; set; }

        [MaxLength(150)]
        public string ActionRequired { get; set; }

    }
} 
 