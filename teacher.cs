using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace te.Data
{
    
    public class teacher
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TID { get; set; }

        [Display(Name = "Department location")]
        public string Dlocation { get; set; }

        [Display(Name = "Teacher Name ")]
        public string Tname { get; set; }
        public int Tlocation { get; set; }


    }
}
