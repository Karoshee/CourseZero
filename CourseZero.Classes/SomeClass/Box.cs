using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.SomeClass
{
    public class Box
    {
        public Box InnerBox { get; set; }

        public int Value { get; set; }

        public override string ToString()
        {
            if (InnerBox is not null)
                return "InnerBox=" + InnerBox.ToString();
            return "Value="+Value;
        }

        public override int GetHashCode()
        {
            if (InnerBox is not null)
                return InnerBox.GetHashCode() ^ Value;
            return Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is Box box)
            {
                return box.Value == Value;
            }
            return false;
        }
    }
}
