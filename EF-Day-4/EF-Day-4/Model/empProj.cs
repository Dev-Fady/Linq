using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day_4.Model
{
    [PrimaryKey(nameof(empId), nameof(projId))] // dot net core >=7
    internal class empProj
    {
         [ForeignKey("employee")]
        //[Key,Column(Order =1)] .net framework
        public int empId { get; set; }

        [ForeignKey("project")]
        //[Key,Column(Order = 2)] .net framework
        public int projId { get; set; }
        public virtual Employee employee { get; set; }
        public virtual Project project { get; set; }
    }
}
