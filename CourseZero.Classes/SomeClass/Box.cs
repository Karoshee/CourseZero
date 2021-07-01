using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes.SomeClass
{
    public class Box
    {
        private int _value;

        public Box InnerBox { get; set; }

        public int Value 
        { 
            get => _value; 
            set => _value = value; 
        }

        //public decimal DecimalValue => (decimal)Value;

        public decimal DecimalValue
        {
            get
            {
                return (decimal)Value;
            }
        }

        public int Value1 { get; set; } = 1;

        public string MyProperty { get; set; }

        public override string ToString()
        {
            if (InnerBox is not null)
                return "InnerBox=" + InnerBox.ToString();
            return "Value=" + Value;
        }

        public override int GetHashCode()
        {
            return Value ^ Value1 ^ MyProperty.GetHashCode();
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
