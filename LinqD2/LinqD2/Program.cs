using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace LinqD2
{
    public class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int duration { get; set; }

        public Subject(int code=0, string name="", int duration = 12)
        {
            Code = code;
            Name = name;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"{Code} - {Name} ({duration} months)";
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public List<Subject> subjects { get; set; }

        public int DeptId { get; set; }

        public Student(int id = 0, string name = "", int age = 0 , int deptId = 0)
        {
            ID = id;
            Name = name;
            this.age = age;
            DeptId = deptId;
        }
    }
    public class studentComapre : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.ID;
        }
    }

    public class Department 
    {
        public int id { get; set; }
        public String dname { get; set; }
        public String location { get; set; }
        public Department(int id = 0, string dname = "", string location = "")
        {
            this.id = id;
            this.dname = dname;
            this.location = location;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
           {
               new Student()
               {
                   ID = 1,
                   Name = "Ali ahmed",
                   age = 22,
                   DeptId = 1,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "SQL", duration: 30),
                       new Subject(code:2,name: "C#",duration:36),
                       new Subject(code:3,name: "JS",duration:24),
                   }
               },
               new Student()
               {
                   ID = 2,
                   Name = "ahmed seraj",
                   age = 23,
                   DeptId = 1,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "HTML", duration: 30),
                       new Subject(code:2,name: "DArt",duration:36),
                       new Subject(code:3,name: "CSS",duration:24),
                   }
               },
               new Student()
               {
                   ID = 1,
                   Name = "Fady Emil",
                   age = 19,
                   DeptId = 2,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "SQL", duration: 30),
                       new Subject(code:2,name: "PHP",duration:36),
                       new Subject(code:3,name: "API",duration:24),
                   }
               },
               new Student()
               {
                   ID = 3,
                   Name = "Tom Emil",
                   age = 45,
                   DeptId = 2,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "SQL", duration: 30),
                       new Subject(code:2,name: "PHP",duration:36),
                       new Subject(code:3,name: "API",duration:24),
                   }
               },
               new Student()
               {
                   ID = 4,
                   Name = "Eissi Eiss",
                   age = 42,
                   DeptId = 3,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "SQL", duration: 30),
                       new Subject(code:2,name: "PHP",duration:36),
                       new Subject(code:3,name: "API",duration:24),
                   }
               },
               new Student()
               {
                   ID = 5,
                   Name = "Test Emil",
                   age = 25,
                   DeptId = 2,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "SQL", duration: 30),
                       new Subject(code:2,name: "PHP",duration:36),
                       new Subject(code:3,name: "API",duration:24),
                   }
               },
               new Student()
               {
                   ID = 6,
                   Name = "Tark",
                   age = 25,
                   subjects = new List<Subject>
                   {
                       new Subject(code: 1, name: "SQL", duration: 30),
                       new Subject(code:2,name: "PHP",duration:36),
                       new Subject(code:3,name: "API",duration:24),
                   }
               },

           };

            List<Department> departments = new List<Department>
            {
                new Department(1,"IT","Cairo"),
                new Department(2,"HR","Giza"),
                new Department(3,"Finance","Alex"),
            };

            #region SelectMany
            //var q1 = students.SelectMany(s => s.subjects, (st, sub) =>
            //{
            //    return new
            //    {
            //        StudentName = st.Name,
            //        sub
            //    };
            //});
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //List<string> names = new List<string>()
            //{
            //    "ali","ahmed","fady","aya"
            //};
            //List<int> numbers = new List<int>()
            //{
            //   1,2,3,4,5
            //};
            //var q2 = names.SelectMany(n => numbers, (name, num) =>
            //{
            //    return new
            //    {
            //        Name = name,
            //        Number = num
            //    };
            //});
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region ofType
            //var li=new ArrayList()
            //{
            //    1,2,3,"ali","ahmed",new Student()
            //    {
            //        ID = 1,
            //        Name = "Ali ahmed",
            //        age = 22,
            //        subjects = new List<Subject>
            //        {
            //            new Subject(code: 1, name: "SQL", duration: 30),
            //            new Subject(code:2,name: "C#",duration:36),
            //            new Subject(code:3,name: "JS",duration:24),
            //        }
            //    }
            //};
            //var q1 = li.OfType<int>();
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //var q2 = li.OfType<Student>().Select(
            //    s=>
            //    new {
            //        info = $"id :{s.ID}, Name:{s.Name},age: {s.age}",
            //        Subjects = string.Join(" | ", s.subjects.Select(sub => $"Code: {sub.Code}, Name: {sub.Name}, Duration: {sub.duration}"))
            //    });

            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region GroupBy
            //List<Student> list = new List<Student>
            //{
            //    new Student(1,"Ali",22,1),
            //    new Student(2,"Ahmed",23,1),
            //    new Student(3,"Fady",19,2),
            //    new Student(4,"Aya",20,2),
            //    new Student(5,"tom",25,3),
            //    new Student(6,"Fares",20,3),
            //    new Student(7,"Fares2",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(9,"bars",24,1)
            //};
            //var q1=list.GroupBy(s=>s.DeptId
            //    ,(key, students) => new
            //    {
            //        Key = key,
            //        Students = students
            //    }
            //);
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var student in item.Students)
            //    {
            //        Console.WriteLine($"  ID: {student.ID}, Name: {student.Name}, Age: {student.age}");
            //    }
            //}
            #endregion
            #region distinct
            //List<Student> list = new List<Student> { 

            //    new Student(1,"Ali",22,1),
            //    new Student(2,"Ahmed",23,1),
            //    new Student(3,"Fady",19,2),
            //    new Student(3,"Fady",19,2),
            //    new Student(4,"Aya",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(5,"tom",25,3),
            //    new Student(6,"Fares",20,3),
            //    new Student(7,"Fares2",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(9,"bars",24,1),
            //    new Student(3,"Fady",19,2),
            //};
            //var q1 = list.Distinct(new studentComapre());
            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.age}, DeptId: {item.DeptId}");
            //}

            #endregion
            #region Union , intersection , Except
            //List<Student> list1 = new List<Student>
            //{
            //    new Student(1,"Ali",22,1),
            //    new Student(2,"Ahmed",23,1),
            //    new Student(3,"Fady",19,2),
            //};
            //List<Student> list2 = new List<Student>
            //{
            //    new Student(3,"Fady",19,2),
            //    new Student(4,"Aya",20,2),
            //    new Student(5,"tom",25,3),
            //    new Student(1,"Ali",22,1),

            //};
            //var q1 = list1.Union(list2,new studentComapre());
            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.age}, DeptId: {item.DeptId}");
            //}
            //Console.WriteLine("===================================");
            //var q2 = list1.Intersect(q1);
            //foreach (var item in q2)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.age}, DeptId: {item.DeptId}");
            //}
            //Console.WriteLine("===================================");
            //var q3 = list1.Except(list2);
            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.age}, DeptId: {item.DeptId}");
            //}
            #endregion
            #region join
            //var q1 = students.Join(departments,
            //    s => s.DeptId,
            //    d => d.id,
            //    (s, d) =>
            //    {
            //        return new
            //        {
            //            StudentName = s.Name,
            //            DepartmentName = d.dname,
            //            Location = d.location
            //        };
            //    }
            //    );
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //var q2 = students.GroupJoin(departments,
            //    s => s.DeptId,
            //    d => d.id,
            //    (s, ds) => new
            //    {
            //        StudentName = s.Name,
            //        Departments = ds.Select(d => new { d.dname, d.location })
            //    });
            //foreach (var item in q2)
            //{
            //    Console.WriteLine($"Student: {item.StudentName}");
            //    foreach (var dept in item.Departments)
            //    {
            //        Console.WriteLine($"  Department: {dept.dname}, Location: {dept.location}");
            //    }
            //}
            //var q3 = departments.GroupJoin(students,
            //    s => s.id,
            //    d => d.DeptId,
            //    (d, s) => new
            //    {
            //        d.dname,
            //        s,
            //    });
            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"Department: {item.dname}");
            //    foreach (var student in item.s)
            //    {
            //        Console.WriteLine($"  Student: {student.Name}, Age: {student.age}");
            //    }
            //}
            #endregion
            #region ElementAtOrDefault
            //var q1 = students.Where(s => s.age > 21).OrderBy(o => o.age)
            // .Select(s => new
            // {
            //     s.ID,
            //     s.Name,
            //     s.age,
            //     Subjects = string.Join(", ", s.subjects.Select(sub => $"{sub.Name} ({sub.duration} months)"))
            // }).ElementAtOrDefault(0);
            //Console.WriteLine($"Element at index 1: {q1}");
            ////foreach (var item in q1)
            ////{
            ////    Console.WriteLine(item);
            ////}
            #endregion
            #region any,all
            //var q1 = students.Any(s => s.age > 30);
            //Console.WriteLine($"Any student older than 30: {q1}");
            //var q2 = students.All(s => s.age >= 19);
            //Console.WriteLine($"All students older than 30: {q2}");
            #endregion
            #region aggregate
            //int[] arr = {1,2,3,4, 5 };
            //var q1=arr.Aggregate((a, b) => a * b);
            //Console.WriteLine($"Product of all elements: {q1}");
            #endregion
            #region Zip , SequenceEqual
            //List<Student> list1 = new List<Student> {

            //    new Student(1,"Ali",22,1),
            //    new Student(2,"Ahmed",23,1),
            //    new Student(3,"Fady",19,2),
            //    new Student(3,"Fady",19,2),
            //    new Student(4,"Aya",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(5,"tom",25,3),
            //    new Student(6,"Fares",20,3),
            //    new Student(7,"Fares2",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(9,"bars",24,1),
            //    new Student(3,"Fady",19,2),
            //};
            //List<Student> list2 = new List<Student> {
            //    new Student(1,"Ali",22,1),
            //    new Student(2,"Ahmed",23,1),
            //    new Student(3,"Fady",19,2),
            //    new Student(3,"Fady",19,2),
            //    new Student(4,"Aya",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(5,"tom",25,3),
            //    new Student(6,"Fares",20,3),
            //    new Student(7,"Fares2",20,2),
            //    new Student(8,"Fhad",23,3),
            //    new Student(9,"bars",24,1),
            //    new Student(3,"Fady",19,2),
            //};
            //var q1 = list1.Zip(list2, (s1, s2) => new
            //{
            //    s1.ID,
            //    s1.Name,
            //    s1.age,
            //    s2.DeptId
            //});
            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.age}, DeptId: {item.DeptId}");
            //}
            //var q2 = list1.SequenceEqual(list2,new studentComapre());
            //Console.WriteLine($"Are both lists equal? {q2}");
            #endregion
            #region Enumerable Range Repeat
            //var q1 = Enumerable.Range(3, 10)
            //    .Select(i => new
            //    {
            //        Number = i,
            //        Square = i * i,
            //        Cube = i * i * i
            //    })
            //    .ToList();
            //Console.WriteLine("Number, Square, Cube");
            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"Number: {item.Number}, Square: {item.Square}, Cube: {item.Cube}");
            //}
            //var q2 = Enumerable.Repeat(10, 5);
            //foreach (var item in q2)
            //{
            //    Console.WriteLine($"Repeated Value: {item}");
            //} 
            #endregion
            #region 
            //var q1 = students.Where(s => s.age > 100).DefaultIfEmpty<Student>(new Student()
            //{
            //    ID = 0,
            //    Name = "No Students",
            //    age = 0,
            //    subjects = new List<Subject>()
            //});
            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Age: {item.age}");
            //    if (item.subjects != null && item.subjects.Count > 0)
            //    {
            //        Console.WriteLine("Subjects:");
            //        foreach (var sub in item.subjects)
            //        {
            //            Console.WriteLine($"  {sub}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No subjects available.");
            //    }
            //}
            #endregion
        }
    }
}
