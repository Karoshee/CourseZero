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
    public class RectangleTests
    {
        [Test()]
        public void AreaTest()
        {
            Rectangle rectangle = new(3, 5);

            rectangle.Area().Should().Be(15);
        }

        [Test()]
        public void PerimeterTest()
        {
            Rectangle rectangle = new(3, 5);

            rectangle.Perimeter().Should().Be(16);
        }
    }
}