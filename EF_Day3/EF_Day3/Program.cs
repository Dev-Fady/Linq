using EF_Day3.Models;

namespace EF_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineRetailDBContext db = new OnlineRetailDBContext();
            var q1 = db.Orders.Where(x => x.TotalAmount > 100).Select(x => new
            {
                x.OrderId,
                x.Customer.FirstName,
                x.Customer.LastName,
                x.OrderDate,
                x.TotalAmount
            });
            var q2 = db.Orders.Where(x => x.TotalAmount > 100).Select(x => new
            {
                x.OrderId,
                x.Customer.FirstName,
                x.Customer.LastName,
                x.OrderDate,
                x.TotalAmount
            }).AsEnumerable();
            var q3 = db.Orders.Where(x => x.TotalAmount > 100).Select(x => new
            {
                x.OrderId,
                x.Customer.FirstName,
                x.Customer.LastName,
                x.OrderDate,
                x.TotalAmount
            }).ToList();
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
