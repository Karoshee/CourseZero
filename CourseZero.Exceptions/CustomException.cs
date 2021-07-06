using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Exceptions
{
    public class CustomException : Exception
    {
        public string Value { get; set; }

        public CustomException(string value)
        {
            Value = value;
        }
    }
}
