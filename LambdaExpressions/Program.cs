using System;


namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression

            // no args: () => ...
            // one arg: x => ...
            // multiple args: (x, y, z) => ...

            //Func<int, int> square = number => number*number;
            //Console.WriteLine(square(5));

            //const int factor = 5;
            //Func<int, int> multiplier = n => n * factor;
            //Console.WriteLine(multiplier(10)); 


            var books = new BookRepository().GetBooks();
            //without lambda expression
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //using lambda expressions
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            
        }

        static bool IsCheaperThan10Dollars(Book book) 
        {
            return book.Price < 10;
        }
    }
}
