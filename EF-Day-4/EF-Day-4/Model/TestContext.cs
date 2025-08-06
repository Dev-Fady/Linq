using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day_4.Model
{
    internal class TestContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<empProj> EmpProjs { get; set; }

        public virtual DbSet<Department> Departments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JR16FNI;Initial Catalog=TestDay4;Integrated Security=True ; Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<empProj>().HasKey("emid", "projId");
            //modelBuilder.Entity<Employee>().Property<String>("name").IsRequired();

            modelBuilder.Entity<Department>().HasData(
                new Department()
                {
                    deptId = 1,
                    Name = "dontNet",
                    loaction = "lec1"
                },
                new Department()
                {
                    deptId = 2,
                    Name = "C#",
                    loaction = "lec2"
                },
                new Department()
                {
                    deptId = 3,
                    Name = "Front",
                    loaction = "lec3"
                }
            );

        }
    }
}
