using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqDayOneAssignmets
{
    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] subjects { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            #region Query1: Display numbers without any repeated Data and sorted
            var q1 = numbers.Distinct().OrderBy(x=>x);
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Query2: using Query1 result and show each number and it’s multiplication
            var q2 = q1.Select(s => new { number = s, multiply = s * s });
            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");
            #endregion
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            #region Query1: Select names with length equal 3.
            var q3 = names.Where(s => s.Length == 3);
            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Query2: Select names that contains “a” letter(Capital or Small)then sort them by length
            var q4 = names.Where(n => n.ToLower().Contains("a")).OrderBy(n=>n.Length);
            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Query3: Display the first 2 names
            var q5 = names.Take(2);
            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");
            #endregion
            #region Query1: Display Full name and number of subjects for each student as follow
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 33, Name = "UML" }
                    }
                },
                new Student()
                {
                    ID = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 34, Name = "XML" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    ID = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new Student()
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Ali",
                    subjects = new Subject[]
                    {
                        new Subject() { Code = 33, Name = "UML" }
                    }
                },
            };
            var q6 = students.Select(s => new
            {
                FullName = s.FirstName + " " + s.LastName,
                NoOfSubject = s.subjects.Length,
            });
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine("--------------------------------------------------");
            #region Query2: Write a query which orders the elements in the list by FirstName
            var q7 = students.OrderByDescending(s=> s.FirstName).ThenBy(s => s.LastName).Select(s => new
            {
                FullName = s.FirstName + " " + s.LastName,
            });
            foreach (var item in q7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");
            #endregion
            #region Query3: Display each student and student’s subject as follow (use selectMany)
            var q8 = students.SelectMany(s => s.subjects, (s, sub) => new
            {
                FullName = s.FirstName + " " + s.LastName,
                SubjectName = sub.Name
            });
            foreach (var item in q8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------------");
            #endregion
            #region BONUS: Then as follow (use GroupBy)
            var q9 = students.SelectMany(s => s.subjects, (s, subj) => new
            {
                FullName = s.FirstName + " " + s.LastName,
                SubjectName = subj.Name
            }).GroupBy(x => x.FullName);
            foreach (var item in q9)
            {
               Console.WriteLine($"Student: {item.Key}");
                foreach (var sub in item)
                {
                    Console.WriteLine($"  Subject: {sub.SubjectName}");
                }   
            }
            #endregion
        }
    }
}
