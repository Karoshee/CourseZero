using NUnit.Framework;
using CourseZero.Reflection.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace CourseZero.Reflection.Homework.Tests
{
    [TestFixture()]
    public class UniversalEqualityComparerTests
    {
        private IEqualityComparer<T> GetComparer<T>()
            => new UniversalEqualityComparer<T>();

        [Test]
        public void ObjectsWithSamePropertiesShuldBeEqual()
        {
            var value1 = new SimpleObject(1, "text1", 2M);
            var value2 = new SimpleObject(1, "text1", 2M);

            var comparer = GetComparer<SimpleObject>();

            comparer.Equals(value1, value2).Should().BeTrue();
        }

        [Test]
        public void ObjectsWithDifferentPropertiesShouldBeNotEqual()
        {
            var value1 = new SimpleObject(2, "text1", 2M);
            var value2 = new SimpleObject(1, "text1", 2M);

            var comparer = GetComparer<SimpleObject>();

            comparer.Equals(value1, value2).Should().BeFalse();
        }

        [Test]
        public void ObjectsWithDifferentPropertiesShouldBeNotEqual2()
        {
            var value1 = new SimpleObject(2, "text", 2M);
            var value2 = new SimpleObject(2, "text1", 2M);

            var comparer = GetComparer<SimpleObject>();

            comparer.Equals(value1, value2).Should().BeFalse();
        }

        [Test]
        public void ObjectsWithDifferentPrivatePropertiesShouldBeNotEqual()
        {
            var value1 = new SimpleObject(2, "text1", 3M);
            var value2 = new SimpleObject(2, "text1", 2M);

            var comparer = GetComparer<SimpleObject>();

            comparer.Equals(value1, value2).Should().BeFalse();
        }

        public void NullObjectsShuldBeEquals()
        {
            var comparer = GetComparer<SimpleObject>();

            comparer.Equals(null, null).Should().BeTrue();
        }

        public void NullAndNotNullObjectsShuoldNotBeEquals()
        {
            var value = new SimpleObject(2, "text1", 3M);

            var comparer = GetComparer<SimpleObject>();

            comparer.Equals(null, value).Should().BeFalse();
            comparer.Equals(value, null).Should().BeFalse();
        }
    }
}