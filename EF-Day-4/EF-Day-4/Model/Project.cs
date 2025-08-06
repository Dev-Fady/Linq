using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day_4.Model
{
    internal class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string location { get; set; }

        public int duration { get; set; }
        
        //public virtual List<Employee> Employees { get; set; }

        public virtual List<empProj> Employees { get; } = new List<empProj>();

    }
}
