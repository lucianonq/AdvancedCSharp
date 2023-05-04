using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime? date = null;
            DateTime? date = null;
            DateTime date2 = date ?? DateTime.Today;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);
            Console.WriteLine(date2);
        }
    }
}
