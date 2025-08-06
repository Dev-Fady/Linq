using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day_4.Model
{
    internal class Test
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }
        
        public string? LastName { get; set; }

        public int? age { get; set; }

        [Column(TypeName = "money")]
        public decimal salary { get; set; }

        public string password { get; set; }

        public string? address { get; set; }
    }
}
