using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object obj = "Mosh";

            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
            //methodInfo.Invoke(null, null);

            //dynamic excelObject = "luciano";
            //excelObject.Optimize();

            dynamic name = "Mosh";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}
