using System;
using System.IO;

namespace ExceptionHandling
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by 0");
            //}
            //catch (ArithmeticException ex)
            //{
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error ocurred.");
            //}

            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error ocurred.");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}

            //try
            //{
            //    using var streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Sorry, an unexpected error ocurred.");
            //}

            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("mosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
