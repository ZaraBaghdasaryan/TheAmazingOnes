using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Common.Classes
{
    public class Quality
    {
        [Key]
        public int Quality_Id { get; set; }

        [MaxLength(150)]
        public string OK { get; set; }
        [MaxLength(150)]
        public string QualityProblem { get; set; }
        
    }
}
 