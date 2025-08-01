namespace LinqD1
{
    public class Student
    {
        public int id { get; set; }
        public int age { get; set; }

        public string name { get; init; }
        public string last_name { get; init; }

        public override string ToString()
        {
            return $"id: {id}, age: {age}, name: {name+" "+last_name}";
        }
    }

    static class StringExtensions
    {
        public static int wordcount(this string str)
        {
            string[] arr = str.Split(' ');
            return arr.Length;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region C# Feature
            #region implicit type local variable var
            //var x = 1;
            ////x = "fady"; error Cannot implicitly convert type 'string' to 'int'
            //x = 5;// true 
            //Console.WriteLine(x);
            //var y = (int?)null;
            //y = 10; // true
            //Console.WriteLine(y); 
            #endregion
            #region object init
            //Student student = new Student()
            //{
            //    id = 3,
            //    age = 25,
            //    name = "Fady Emil"
            //};
            //student.id = 1;
            //student.age = 20;
            ////student.name = "Fady"; error Cannot modify init-only property 'name'
            //Console.WriteLine(student.ToString());
            #endregion
            #region anynoums object
            //var +new + object init
            //var obj = new
            //{
            //    id = 3,
            //    age = 25,
            //    name = "Fady Emil"
            //};
            ////obj.age = 20; error Cannot modify init-only property 'age'
            //Console.WriteLine(obj);

            //Student st1 = new Student()
            //{
            //    id = 2,
            //    age= 30,
            //    name = "Fady",
            //    last_name= "Emil"
            //};
            //var obj2= new
            //{
            //    st1.id,
            //    st1.age,
            //   fullName= $"{st1.name} {st1.last_name}"
            //};
            //Console.WriteLine(obj2);
            #endregion
            #region anonymous methods
            //Func<int, int, int> add = delegate (int x, int y)
            //{
            //    return x + y;
            //};
            //Func<int, int, int> add2 = (x, y) => x + y;

            //Console.WriteLine(add(5, 10));

            //Console.WriteLine(add2(5, 10));

            //List<String> li = new()
            //{
            //    "Fady",
            //    "Emil",
            //    "tom",
            //    "ali"
            //};
            //List<String> li2 = li.FindAll(delegate (string s)
            //  {
            //      return s.Contains("a");
            //  });
            //List<String> li3 = li.FindAll(s=>s.Contains("a"));
            //foreach (var item in li2)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in li3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region extension methods
            //String txt = "Hello World";
            //Console.WriteLine(txt.wordcount());
            #endregion

            #endregion

            #region Linq
            List<Student> sts= new List<Student>()
            {
                new Student(){ id = 1,age = 20, name = "Fady",last_name="Emil"},
                new Student(){ id = 2,age = 25, name = "tom",last_name="basta"},
                new Student(){ id = 3,age = 30, name = "test",last_name="Eissa"},
                new Student(){ id = 4,age = 35, name = "nana",last_name="ali"},
            };
            // without linq
            /* List<Student> result = new List<Student>();
             foreach (var item in sts)
             {
                 if (item.age > 25)
                 {
                     result.Add(item);
                 }
             }
             foreach (var item in result)
             {
                 Console.WriteLine(item);
             }*/

            //with linq
            #region where
            //var res1 = Enumerable.Where(sts, s => s.age > 25);
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //}
            //var res2 = sts.Where(s => s.name.Contains("t")).Select(sts => new
            //{
            //    sts.id,
            //    sts.age,
            //    fullName = $"{sts.name} {sts.last_name}"
            //});
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region select
            //var res = sts.Select(
            //    n => new
            //{
            //    id= n.id,
            //    fullName= n.name + " " + n.last_name,
            //});
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region query Exp
            //var res = from s in sts
            //          where s.age>25
            //         select new
            //         {
            //             s.id,
            //             fullName = $"{s.name} {s.last_name}"
            //         };
            //foreach (var item in res)
            //    Console.WriteLine(item);
            #endregion
            #region deferred vs immediate execution
            //var q1=sts.Where(s => s.age > 25)
            //    .Select(s => new
            //    {
            //        s.id,
            //        fullName = $"{s.name} {s.last_name}"
            //    });
            //sts.Add(new Student() { id = 5, age = 40, name = "new", last_name = "student" });
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //sts.Add(new Student() { id = 6, age = 40, name = "new6", last_name = "student6" });
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===================================");
            //// q1 is deferred execution, it will execute when we iterate over it
            //// if we want to execute it immediately we can use ToList() or ToArray()
            //var q2 = q1.ToList(); // this will execute the query and store the result in a list
            //sts.Add(new Student() { id = 7, age = 45, name = "new2", last_name = "student2" });
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Cast operator
            //var q1 = sts.Where(s => s.id > 2).ToList();
            //var q2 = sts.Where(s => s.id == 2).SingleOrDefault();
            //var q3 = sts.Where(s => s.id == 2).Single();
            //var q4 = sts.Where(s => s.id >= 2).First();
            //var q5 = sts.Where(s => s.id >= 2).Last();
            //Console.WriteLine(q2);
            //Console.WriteLine(q4);
            //Console.WriteLine(q5);
            #endregion
            #region  Distinct, Min, Max, Average, Count, Sum , Take, Skip, TakeWhile, SkipWhile
            //var q1 = sts.Select(s => $"{s.name} {s.last_name}").Distinct();
            //sts.Add(new Student() { id = 5, age = 40, name = "Fady", last_name = "Emil" });
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //var q2 = sts.Select(s => s.age).Min();
            //var q3 = sts.Select(s => s.age).Max();
            //var q4 = sts.Select(s => s.age).Average();
            //var q5 = sts.Select(s => s.age).Count();
            //var q6 = sts.Select(s => s.age).Sum();
            //Console.WriteLine($"Min age: {q2}");
            //Console.WriteLine($"Max age: {q3}");
            //Console.WriteLine($"Average age: {q4}");
            //Console.WriteLine($"Count: {q5}");
            //Console.WriteLine($"Sum: {q6}");

            //var q7 = sts.Where(s => s.age >= 20).Take(2);
            //var q8 = sts.Where(s => s.age >= 20).Skip(2);
            //Console.WriteLine($"Take 2:");
            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Skip 2:");
            //foreach (var item in q8)
            //{
            //    Console.WriteLine(item);
            //}
            //var q9 = sts.Where(s => s.age >= 20).Take(2).Skip(1).SingleOrDefault();
            //Console.WriteLine($"Take 2 and Skip 1: {q9}");
            //int[] arr = {1, 2, 3, 4, 33,44,4,5,8,9};
            //var q10 = arr.TakeWhile(x => x < 10);
            //Console.WriteLine("TakeWhile x < 10:");
            //foreach (var item in q10)
            //{
            //    Console.WriteLine(item);
            //}
            //var q11 = arr.SkipWhile(x => x < 10);
            //Console.WriteLine("SkipWhile x < 10");
            //foreach (var item in q11)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region order by
            //var q1 = sts.Where(s => s.age > 20).OrderByDescending(s => s.last_name);
            //var q2 = sts.Where(s => s.age > 20).OrderByDescending(s => s.last_name).ThenByDescending(n=>n.age);
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("===================================");
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion
        }
    }
}
