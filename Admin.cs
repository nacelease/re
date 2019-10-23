using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace te.Data
{
    public class Admin
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }

        [Display(Name = "Department location")]
        public string Dlocation { get; set; }

        [Display(Name = "Department Owner")]
        public string DOwner { get; set; }
        public int DID { get; set; }

     

    }
}
