using System;
using System.Reflection;

namespace CourseZero.Reflection
{
    public static class BasicMapper
    {

        public static T MapTo<T>(this T input)
        {
            Type type = typeof(T);

            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            object output = Activator.CreateInstance(type);

            foreach (PropertyInfo property in properties)
            {
                var value = property.GetValue(input);
                property.SetValue(output, value);
            }

            return (T)output;
        }

    }
}
