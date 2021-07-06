using System;
using CourseZero.Extensions.Library;

namespace CourseZero.Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = 
                { 
                    "string 1", 
                    "123,", 
                    "7 yf " 
                };

            string combined = strings.Join(" ");

            //combined = ExtensionMethods.Method(combined);
            combined = combined.Method();
            Console.WriteLine(combined);
            Console.ReadKey();
        }
    }
}
