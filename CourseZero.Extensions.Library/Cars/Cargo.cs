using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Extensions.Library.Cars
{
    [Serializable]
    public class Cargo
    {
        public decimal Weight { get; set; }

        public override string ToString()
        {
            return Weight.ToString();
        }
    }
}
