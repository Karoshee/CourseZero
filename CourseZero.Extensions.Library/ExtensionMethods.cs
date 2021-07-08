using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Extensions.Library
{
    public static class ExtensionMethods
    {
        public static string Join(this string[] strings, string separator)
            => string.Join(separator, strings);

        public static string Method(this string input)
        {
            //if (input is null || input == "")
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            string result = input.Trim();

            if (input == "")
                return result;

            if (char.IsLower(result[0]))
            {
                result = char.ToUpper(result[0]) + result.Substring(1);
            }

            //if (result[result.Length -1] != '.')
            if (result[^1] != '.')
            {
                result += ".";
            }

            return result;
        }

    }
}
