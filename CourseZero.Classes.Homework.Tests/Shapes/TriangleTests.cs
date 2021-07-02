using NUnit.Framework;
using CourseZero.Classes.Homework.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace CourseZero.Classes.Homework.Shapes.Tests
{
    [TestFixture()]
    public class TriangleTests
    {

        [Test()]
        public void AreaTest()
        {
            Triangle triangle1 = new(3, 4, 5M);
            Triangle triangle2 = new(2, 3, 30D);

            triangle1.Area().Should().Be(1.5M);
            triangle2.Area().Should().Be(6M);
        }

        [Test()]
        public void PerimeterTest()
        {
            Triangle triangle1 = new(3, 4, 5M);
            Triangle triangle2 = new(2, 3, 30D);

            decimal area;
            triangle1.Area().Should().Be(12M);
            area = triangle2.Perimeter();
            area.Should().BeGreaterThan(6.6147M);
            area.Should().BeLessThan(6.6150M);
        }
    }
}