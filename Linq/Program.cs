using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Linq Query operators (better for group by or grouping list)
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            //LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book);
            //Console.WriteLine(book.Title + " " + book.Price);

            //var book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            //var book = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            //var book = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var book in pagedBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            var count = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);
        }
    }
}
