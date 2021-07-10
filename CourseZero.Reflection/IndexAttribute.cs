using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Reflection
{
    public class IndexAttribute : Attribute
    {
        public int Index { get; set; }

        public IndexAttribute(int index)
        {
            Index = index;
        }
    }
}
