using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace te.Data
{
    public class student
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int dnumber { get; set; }

        [Display(Name = "Department location")]
        public string Dlocation { get; set; }

        [Display(Name = "Department Owner")]
        public string DOwner { get; set; }
        public int DID { get; set; }

        [ForeignKey("AID")]
        public Admin add { get; set; }

        [ForeignKey("TID")]
        public teacher teacher { get; set; }


    }
}
