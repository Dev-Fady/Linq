using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day_4.Model
{
    [Table("Employees", Schema = "hr")]
    internal class Employee
    {
        [Required]
        public int id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string name { get; set; }

        public int? age { get; set; }

        [Column(TypeName = "money")]
        public decimal salary { get; set; }

        public string password { get; set; }

        public string? address { get; set; }

        public virtual Department dept { get; set; }

        [ForeignKey("dept")]
        public int deptId { get; set; }

        //public virtual List<Project> Projects { get; set; }

        public virtual List<empProj> Projects { get; } = new List<empProj>();

    }
}
