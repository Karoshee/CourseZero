using System;

using System.ComponentModel;
using System.Reflection;

namespace CourseZero.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = CustomClass.Build();
            x.InnerText = "text";
            var x1 = x.MapTo();

        }
    }
}
