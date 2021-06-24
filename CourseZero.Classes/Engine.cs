using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    public class Engine
    {
        public byte Power { get; }

        public decimal Consumption { get; }

        public Engine(byte power)
        {
            Power = power;
            Consumption = Power / 21;
        }
    }
}
