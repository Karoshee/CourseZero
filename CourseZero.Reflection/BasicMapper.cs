using System;
using System.Reflection;
using System.Linq;

namespace CourseZero.Reflection
{
    public static class BasicMapper
    {

        public static T MapTo<T>(this T input)
        {
            //Type type = input.GetType();
            Type type = typeof(T);

            ConstructorInfo constructor = type
                .GetConstructors()
                .FirstOrDefault(c => c.GetParameters().Length == 0);

            if (constructor == default(ConstructorInfo))
                throw new ArgumentException("У этого типа нет конструктора без параметров, а должен быть");

            T output = (T)Activator.CreateInstance(type);

            PropertyInfo[] properties = type.GetProperties(
                BindingFlags.Public | 
                BindingFlags.NonPublic | 
                BindingFlags.GetProperty | 
                BindingFlags.SetProperty | 
                BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                var value = property.GetValue(input);
                property.SetValue(output, value);
            }

            return output;
        }

        //public static CustomClass MapTo(CustomClass input)
        //{
        //    CustomClass output = new()
        //    {
        //        Index = input.Index,
        //        InnerText = input.InnerText,
        //        Text = input.Text
        //    };
        //    return output;
        //}

    }
}
