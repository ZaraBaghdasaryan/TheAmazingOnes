using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Common.Classes
{
    public class Material
    {
        [Key]
        public int Material_Id { get; set; }

        [MaxLength(150)]
        public string OK { get; set; }
        [MaxLength(150)]
        public string MaterialProblem { get; set; }

    }
}
 