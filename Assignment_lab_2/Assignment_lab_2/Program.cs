using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            #region Restriction Operators
            //var allProdcts = ListGenerators.ProductList;
            //foreach (var item in allProdcts)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var allProdctsMoreThan3 = ListGenerators.ProductList.Where(p => p.UnitPrice > 30);
            //foreach (var item in allProdctsMoreThan3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Select((name, index) => new
            //{
            //    Name = name,
            //    Value = index
            //}).Where(x => x.Name.Length < x.Value)
            //.Select(s => s.Value);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region  Element Operators
            //var FirstProduct=ListGenerators.ProductList.ElementAtOrDefault(0);
            //Console.WriteLine(FirstProduct);
            //var q1=ListGenerators.ProductList.Where(x=>x.UnitPrice > 1000).FirstOrDefault();
            //if (q1 != null)
            //{
            //    Console.WriteLine($"Product: {q1.ProductName}, Price: {q1.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found with price > 1000");
            //}
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q2 = Arr.Where(x => x > 5).ElementAtOrDefault(1);
            //Console.WriteLine(q2);
            #endregion
            #region Set Operators

            //var uniqueCategories = ListGenerators.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}
            //Console.WriteLine("========================================");
            //var uniqueCustomerNames = ListGenerators.CustomerList
            //    .Select(c=>c.CompanyName)
            //    .Distinct();
            //foreach (var customerName in uniqueCustomerNames)
            //{
            //    Console.WriteLine(customerName);
            //}
            //    Console.WriteLine("========================================");
            //var firstLatterUniqueCategories = uniqueCategories.Select(c => c.First());
            //foreach (var item in firstLatterUniqueCategories)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var firstLatterUniqueCustomerNames = uniqueCustomerNames.Select(c => c.First());
            //foreach (var item in firstLatterUniqueCustomerNames)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("========================================");
            //var commonFirstLetters = firstLatterUniqueCategories.Intersect(firstLatterUniqueCustomerNames);
            //foreach (var item in commonFirstLetters)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var productOnlyLetters = ListGenerators.ProductList.Select(p=>p.ProductName).Select(name => name[0])
            //    .Distinct()
            //    .Except(firstLatterUniqueCustomerNames);
            //foreach (var item in productOnlyLetters)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var customerLastTherreLetters = ListGenerators.CustomerList.Select(c => c.CompanyName)
            //    .Where(name => name.Length >= 3)
            //    .Select(name => name.Substring(name.Length - 3));
            //var productLastThree = ListGenerators.ProductList.Select(p => p.ProductName)
            //    .Where(name => name.Length >= 3)
            //    .Select(name => name.Substring(name.Length - 3));
            //var allLastThere = productLastThree.Concat(customerLastTherreLetters);
            //foreach (var item in allLastThere)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Aggregate Operators

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q1 = Arr.Where(x => x % 2 != 0).Count();
            //Console.WriteLine($"Count of odd numbers: {q1}");

            //var customerOrdersCount = ListGenerators.CustomerList.Select(c => new
            //{
            //    c.CompanyName,
            //    c.Orders.Length
            //});
            //foreach (var item in customerOrdersCount)
            //{
            //    Console.WriteLine($"Customer: {item.CompanyName}, Orders Count: {item.Length}");
            //}
            //Console.WriteLine("========================================");
            //var categoriesProductsCount = ListGenerators.ProductList
            //    .GroupBy(p=>p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Count = g.Count()
            //    });
            //foreach (var item in categoriesProductsCount)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var totalArr= Arr.Aggregate((x, y) => x + y);
            //Console.WriteLine($"Total of array elements: {totalArr}");

            #region Read dictionary_english.txt into Array of String First
            //Console.WriteLine("=========================");
            //string[] ArrSrting = File.ReadAllLines("dictionary_english.txt");
            //int count= ArrSrting.Sum(w=>w.Length);
            //Console.WriteLine($"Total of dictionary words: {count}");

            #endregion
            //var totalUnitProcductCategory = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        totoalunit= g.Sum(p=>p.UnitsInStock)
            //    });
            //foreach (var item in totalUnitProcductCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.totoalunit}");
            //}

            //string[] ArrSrting = File.ReadAllLines("dictionary_english.txt");
            //var shortestWord = ArrSrting.Aggregate((x, y) => x.Length < y.Length ? x : y);
            //Console.WriteLine($"Shortest word in dictionary: {shortestWord} length is {shortestWord.Length}");

            //var cheapestPriceCategoryProcuct = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        price = g.Min(p => p.UnitPrice)
            //    });
            //foreach (var item in cheapestPriceCategoryProcuct)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] ArrSrting = File.ReadAllLines("dictionary_english.txt");
            //var LongestWord = ArrSrting.Aggregate((x, y) => x.Length > y.Length ? x : y);
            //Console.WriteLine($"Logest word in dictionary: {LongestWord} length is {LongestWord.Length}");

            //var expensivePriceCategoryProcuct = ListGenerators.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        price = g.Max(p => p.UnitPrice)
            //    });
            //foreach (var item in expensivePriceCategoryProcuct)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var expensiveCategoryProcuct = ListGenerators.ProductList
            //   .GroupBy(p => p.Category)
            //  .SelectMany(g =>
            //  {
            //      var maxPrice = g.Max(p => p.UnitPrice);
            //      return g.Where(p => p.UnitPrice == maxPrice)
            //             .Select(p => new
            //             {
            //                 Category = g.Key,
            //                 ProductName = p.ProductName,
            //                 Price = p.UnitPrice
            //             });
            //  });
            //foreach (var item in expensiveCategoryProcuct)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] ArrSrting = File.ReadAllLines("dictionary_english.txt");
            //var averageLength = ArrSrting.Select(w => w.Length).Average();
            //Console.WriteLine($"average Length word in dictionary: {averageLength}");

            //var averagePriceCategoryProcuct = ListGenerators.ProductList
            //   .GroupBy(p => p.Category)
            // .Select(g => new
            // {
            //     category = g.Key,
            //     price = g.Average(p => p.UnitPrice)
            // });
            //foreach (var item in averagePriceCategoryProcuct)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Ordering Operators
            //var ListSortName = ListGenerators.ProductList.OrderBy(x => x.ProductName);
            //foreach (var item in ListSortName)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("========================================");
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var q1 = Arr.OrderBy(x => x ,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("========================================");
            //var ProuctsUnitSort = ListGenerators.ProductList.OrderBy(x => x.UnitPrice).Reverse();
            //foreach (var item in ProuctsUnitSort)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("========================================");
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var q2 = Arr.OrderBy(x => x.Length).ThenBy(x => x);
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var q3 = ListGenerators.ProductList
            //    .OrderBy(x => x.Category)
            //    .ThenByDescending(x => x.UnitPrice);
            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");

            #endregion
            #region Partitioning Operators
            //var first3Orders = ListGenerators.CustomerList
            //.Where(c => c.City.Contains("W"))
            //.SelectMany(c => c.Orders.Select(o => new { o, c.CompanyName }))
            //.OrderBy(x => x.o.OrderDate)
            //.Take(3);

            //foreach (var item in first3Orders)
            //{
            //    Console.WriteLine($"Customer: {item.CompanyName}, Order ID: {item.o.OrderID}, Date: {item.o.OrderDate}");
            //}
            //Console.WriteLine("========================================");
            //var Orders = ListGenerators.CustomerList
            //.Where(c => c.City.Contains("W"))
            //.SelectMany(c => c.Orders.Select(o => new { o, c.CompanyName }))
            //.OrderBy(x => x.o.OrderDate)
            //.Skip(2);

            //foreach (var item in Orders)
            //{
            //    Console.WriteLine($"Customer: {item.CompanyName}, Order ID: {item.o.OrderID}, Date: {item.o.OrderDate}");
            //}
            //Console.WriteLine("========================================");
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q1 = numbers.Select((x, index) => new { Value = x, Index = index })
            //    .TakeWhile(x => x.Value >= x.Index)
            //    .Select(x => x.Value);
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var q2 = numbers.SkipWhile(x => x % 3 != 0).Select(x=>x);
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Projection Operators
            //var productNames = ListGenerators.ProductList
            //    .Select(p => p.ProductName);
            //foreach (var item in productNames)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //// create Empty List
            //var EmptyLatterUpper = new List<string>();
            //var res = words.Select(w => new
            //{
            //    Letters = w.Select(c => new
            //    {
            //        latter =c,
            //        IsLower = char.IsLower(c),
            //        IsUpper = char.IsUpper(c),
            //    }).Where(c => c.IsUpper)
            //});
            //foreach (var item in res)
            //{
            //    foreach (var item1 in item.Letters)
            //    {
            //        Console.WriteLine(item1.latter);
            //    }

            //}

            //Console.WriteLine("========================================");
            //var productDetails = ListGenerators.ProductList.Select(s => new
            //{
            //    s.ProductName,
            //    price = s.UnitPrice,
            //});
            //foreach (var item in productDetails)
            //{
            //    Console.WriteLine($"Product: {item.ProductName}, Price: {item.price}");
            //}
            //Console.WriteLine("========================================");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var q1 = Arr.Select((x, index) => new
            //{
            //    x = x,
            //    Index = index,
            //    inPlace=x == index
            //});
            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"{item.x}:\t{item.inPlace}");
            //}
            //Console.WriteLine("========================================");
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var res = numbersA
            //     .SelectMany(a => numbersB, (a, b) => new
            //     {
            //         a,
            //         b
            //     })
            //     .Where(x => x.a < x.b)
            //     .Select(x => new { x.a, x.b });
            //foreach (var item in res)
            //{
            //    if (item.a<item.b)
            //    {
            //        Console.WriteLine($"{item.a} less than {item.b}");
            //    }
            //}

            //Console.WriteLine("========================================");

            //var TotalOrdersLess500 = ListGenerators.CustomerList
            //    .SelectMany(c => c.Orders, (customer, order) => new
            //    {
            //        CustomerName = customer.CompanyName,
            //        OrderID = order.OrderID,
            //        Total = order.Total
            //    })
            //    .Where(x => x.Total < 500);
            //foreach (var item in TotalOrdersLess500)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("========================================");
            //var AllOrdersIN1998 = ListGenerators.CustomerList
            //    .SelectMany(c => c.Orders, (customer, order) => new
            //    {
            //        CustomerName = customer.CompanyName,
            //        orderDate = order.OrderDate,
            //    })
            //    .Where(x => x.orderDate.Year == 1998);
            //foreach (var item in AllOrdersIN1998)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Quantifier

            #region Read dictionary_english.txt into Array of String First
            //string[] ArrSrting = File.ReadAllLines("dictionary_english.txt");

            //int containSubstringEi = ArrSrting
            //    .Count(w => w.ToLower().Contains("ei"));

            //Console.WriteLine($"Number of words containing 'ei': {containSubstringEi}");

            //foreach (var item in ArrSrting.Where(w => w.ToLower().Contains("ei")))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            // var groupedProducts = ListGenerators.ProductList
            //  .GroupBy(p => p.Category)
            //  .Where(
            //      g => g.Any(p => p.UnitsInStock == 0)
            //     )
            //  .Select(g => new
            //  {
            //      Category = g.Key,
            //      OutOfStockProducts = g.Where(p => p.UnitsInStock == 0)
            //  });

            // foreach (var group in groupedProducts)
            // {
            //     Console.WriteLine($"Category: {group.Category}");
            //     foreach (var product in group.OutOfStockProducts)
            //     {
            //         Console.WriteLine($"  - {product.ProductName} (In stock: {product.UnitsInStock})");
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine("========================================");
            // var groupedProductsAll = ListGenerators.ProductList
            //.GroupBy(p => p.Category)
            //.Where(
            //    g => g.Any(p => p.UnitsInStock > 0)
            //   )
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    OutOfStockProducts = g.Where(p => p.UnitsInStock > 0)
            //});

            // foreach (var group in groupedProductsAll)
            // {
            //     Console.WriteLine($"Category: {group.Category}");
            //     foreach (var product in group.OutOfStockProducts)
            //     {
            //         Console.WriteLine($"  - {product.ProductName} (In stock: {product.UnitsInStock})");
            //     }
            //     Console.WriteLine();
            // }

            #endregion
            #region Grouping Operators
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //var grouped=numbers.GroupBy(x => x % 5)
            //    .Select(g => new
            //    {
            //        Remainder = g.Key,
            //        Numbers = g.ToList()
            //    });
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine($"Remainder: {group.Remainder}");
            //    foreach (var number in group.Numbers)
            //    {
            //        Console.WriteLine($"  - {number}");
            //    }
            //}

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var groupedWords = words
            //    .GroupBy(w => Char.ToUpper( w[0]))
            //    .Select(g => new
            //    {
            //        Length = g.Key,
            //        Words = g.ToList()
            //    });
            //foreach (var group in groupedWords)
            //{
            //    Console.WriteLine($"Words starting with '{group.Length}':");
            //    foreach (var word in group.Words)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine();
            //}


            #endregion
        }
    }
}
