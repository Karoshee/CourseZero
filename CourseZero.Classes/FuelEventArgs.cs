using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Classes
{
    public class FuelEventArgs : EventArgs
    {
        public decimal FuelConsumedFromLastMove { get; }

        public FuelEventArgs(decimal fuelConsumedFromLastMove)
        {
            FuelConsumedFromLastMove = fuelConsumedFromLastMove;
        }
    }
}
