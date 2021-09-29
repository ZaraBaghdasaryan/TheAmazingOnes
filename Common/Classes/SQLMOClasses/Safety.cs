using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Common.Classes
{
    public class Safety
    {
        [Key]
        public int Safety_Id { get; set; }

        [MaxLength(150)]
        public string OK { get; set; }

        [MaxLength(150)]
        public string Incident { get; set; }

        [MaxLength(150)]
        public string Accident { get; set; }
    }
}
   