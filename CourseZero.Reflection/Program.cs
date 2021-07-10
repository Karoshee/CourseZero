using System;

using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace CourseZero.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomClass x = CustomClass.Build();
            x.InnerText = "text";
            x.Text = "111";

            x.GetType().GetField("_index", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(x, 100);

            x.GetType().GetMethod("DoTheThing", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(x, new object[0]);

            x.GetType().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault(x => x.Name == "DoTheThing")?.Invoke(x, new object[0]);

            CustomClass x1 = x.MapTo();
            x1.Index += 10;

            var propertyDescription = x
                .GetType()
                .GetProperty(nameof(CustomClass.InnerText))
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;

            var index = x
                  .GetType()
                  .GetProperty(nameof(CustomClass.InnerText))
                  .GetCustomAttribute<IndexAttribute>()
                  .Index;

            Console.Write(propertyDescription + " ");
            x.InnerText = Console.ReadLine();
        }
    }
}
