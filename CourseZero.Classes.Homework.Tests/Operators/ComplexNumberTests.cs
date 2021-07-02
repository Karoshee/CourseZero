using NUnit.Framework;
using CourseZero.Classes.Homework.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace CourseZero.Classes.Homework.Operators.Tests
{
    [TestFixture()]
    public class ComplexNumberTests
    {
        [Test]
        public void GetHashCodeTest()
        {
            ComplexNumber number1 = new(1, 2);
            ComplexNumber number2 = new(1, 2);
            ComplexNumber number3 = new(1, 0);
            ComplexNumber number4 = new(1, 0);
            ComplexNumber number5 = new(0, 2);
            ComplexNumber number6 = new(0, 2);

            number1.GetHashCode().Should().Be(number2.GetHashCode());
            number3.GetHashCode().Should().Be(number4.GetHashCode());
            number5.GetHashCode().Should().Be(number6.GetHashCode());
        }

        [Test]
        public void EqualsTest()
        {
            ComplexNumber number1 = new(1, 2);
            ComplexNumber number2 = new(1, 2);
            ComplexNumber number3 = new(1, 0);
            ComplexNumber number4 = new(0, 2);

            number1.Equals(number2).Should().BeTrue();
            number1.Equals(number3).Should().BeFalse();
            number1.Equals(number4).Should().BeFalse();
            number3.Equals(number4).Should().BeFalse();
        }

        [Test]
        public void OperatorPlusTest()
        {
            ComplexNumber number1 = new(1, 2);
            ComplexNumber number2 = new(1, 2);
            ComplexNumber number3 = new(1, 0);
            ComplexNumber number4 = new(0, 2);

            (number1 + number2).Should().Be(new ComplexNumber(2, 4));
            (number1 + number3).Should().Be(new ComplexNumber(2, 2));
            (number1 + number4).Should().Be(new ComplexNumber(1, 4));
            (number1 + number2 + number3 + number4).Should().Be(new ComplexNumber(3, 6));
        }

        [Test]
        public void OperatorMinusTest()
        {
            ComplexNumber number1 = new(1, 2);
            ComplexNumber number2 = new(1, 2);
            ComplexNumber number3 = new(1, 0);
            ComplexNumber number4 = new(0, 2);

            (number1 - number2).Should().Be(new ComplexNumber(0, 0));
            (number1 - number3).Should().Be(new ComplexNumber(0, 2));
            (number1 - number4).Should().Be(new ComplexNumber(1, 0));
            (number1 - number2 - number3 - number4).Should().Be(new ComplexNumber(-1, -2));
        }

        [Test]
        public void OperatorMultiplyTest()
        {
            ComplexNumber number1 = new(2, 2);
            ComplexNumber number2 = new(2, 2);
            ComplexNumber number3 = new(2, 0);
            ComplexNumber number4 = new(0, 2);

            (number1 * number2).Should().Be(new ComplexNumber(4, 4));
            (number1 * number3).Should().Be(new ComplexNumber(4, 0));
            (number1 * number4).Should().Be(new ComplexNumber(0, 4));
            (number1 * number2 * number3 * number4).Should().Be(new ComplexNumber(0, 0));
        }

        [Test]
        public void OperatorDivideTest()
        {
            ComplexNumber number1 = new(2, 2);
            ComplexNumber number2 = new(2, 2);
            ComplexNumber number3 = new(2, 1);
            ComplexNumber number4 = new(1, 2);

            (number1 / number2).Should().Be(new ComplexNumber(1, 1));
            (number1 / number3).Should().Be(new ComplexNumber(1, 2));
            (number1 / number4).Should().Be(new ComplexNumber(2, 1));
            (number1 / number2 / number3 / number4).Should().Be(new ComplexNumber(0.5M, 0.5M));
        }

        [Test]
        public void CastOperatorTest()
        {
            ComplexNumber number1 = 1;
            ComplexNumber number2 = 3d;
            ComplexNumber number3 = 3M;
            decimal number4 = (decimal)new ComplexNumber(2, 2);

            number1.ToString().Should().Be("1");
            number2.ToString().Should().Be("3");
            number3.ToString().Should().Be("3");
            number4.Should().Be(2M);
        }

        [Test]
        public void ToStringTest()
        {
            ComplexNumber number1 = new(1, 2);
            ComplexNumber number2 = new(1, 0);
            ComplexNumber number3 = new(0, 2);

            number1.ToString().Should().Be("1 + 2i");
            number2.ToString().Should().Be("1");
            number3.ToString().Should().Be("2i");
        }
    }
}