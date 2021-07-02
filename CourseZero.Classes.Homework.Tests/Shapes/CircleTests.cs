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
    public class CircleTests
    {
        [Test()]
        public void AreaTest()
        {
            Circle circle = new(9);

            var area = circle.Area();
            area.Should().BeGreaterThan(254.468M);
            area.Should().BeLessThan(254.470M);
        }

        [Test()]
        public void PerimeterTest()
        {
            Circle circle = new(9);

            var length = circle.Perimeter();
            length.Should().BeGreaterThan(56.5486m);
            length.Should().BeLessThan(56.5488m);
        }
    }
}