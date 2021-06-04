using NUnit.Framework;
using CourseZero.Scripting.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace CourseZero.Scripting.Homework.Tests
{
    [TestFixture()]
    public class ArithmeticTasksTests
    {
        [TestCase(4)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(41)]
        [TestCase(-123)]
        public void FactorialTest(int number)
        {
            if (number < 0)
            {
                Action factorial = () => ArithmeticTasks.Factorial(number);
                factorial.Should().Throw<Exception>();
                return;
            }

            int expected = 1;
            for (int i = 1; i <= number; i++)
            {
                expected *= i;
            }
            int result = ArithmeticTasks.Factorial(number);
            result.Should().Be(expected);
        }

        [Test(Description = "Факториала отрицательного числа не бывает")]
        public void FactorialNegativeTest()
        {
            Action factorial = () => ArithmeticTasks.Factorial(-10);
            factorial.Should().Throw<Exception>();
            return;
        }

        [Test()]
        public void RemainderTest()
        {

        }
    }
}