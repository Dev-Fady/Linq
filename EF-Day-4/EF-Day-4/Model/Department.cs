using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day_4.Model
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int deptId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string? loaction { get; set; }

        public virtual List<Employee> Employees { get; set; }

    }
}
