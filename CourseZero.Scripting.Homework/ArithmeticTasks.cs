using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseZero.Scripting.Homework
{
    public static class ArithmeticTasks
    {

        public static int Factorial(int number)
        {
            int rez = 1;
            for (int i = 1; i < number; i++)
            {
                rez += i; 
            }
            return rez;
        }

        public static int Remainder(int number, int divider)
        {
            throw new NotImplementedException();
        }
    }
}
