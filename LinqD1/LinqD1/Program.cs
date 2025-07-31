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
            return $"id: {id}, age: {age}, name: {name}";
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
        }
    }
}
