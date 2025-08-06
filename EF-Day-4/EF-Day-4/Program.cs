using EF_Day_4.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestContext db=new TestContext();
            var q1 = db.Employees.Include(d=>d.dept);
            var q2 = db.Departments;
            foreach (var item in q1)
            {
                Console.WriteLine($"name : {item.name} \t salary {item.salary} address {item.address} depart naem :  {item.dept.Name}");
            }
            Console.WriteLine("----------------------------------");
            foreach (var item in q2)
            {
                Console.WriteLine($"deptId : {item.deptId} \t Name {item.Name} \t Location {item.loaction}");
            }
        }
    }
}
