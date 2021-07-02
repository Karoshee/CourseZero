using NUnit.Framework;
using CourseZero.Classes.Homework.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace CourseZero.Classes.Homework.Generics.Tests
{
    [TestFixture()]
    public class SortedStackTests
    {

        [Test]
        public void ToStringTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);
            stack.ToString().Should().Be("[0, 1, 2, 3, 4, 5, 10]");
        }

        [Test()]
        public void AddTest()
        {
            SortedStack<int> stack = new();
            stack.Add(8);
            stack.Add(9);
            stack.Add(0);
            stack.Add(3);
            stack.Add(1);
            stack.ToString().Should().Be("[0, 1, 3, 8, 9]");
        }

        [Test()]
        public void DeleteTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);
            stack.Delete(1);
            stack.ToString().Should().Be("[0, 2, 3, 4, 5, 10]");
        }

        [Test()]
        public void DeleteFirstTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);
            stack.Delete(0);
            stack.ToString().Should().Be("[1, 2, 3, 4, 5, 10]");
        }

        [Test()]
        public void DeleteLastTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);
            stack.Delete(6);
            stack.ToString().Should().Be("[0, 1, 2, 3, 4, 5]");
        }

        [Test()]
        public void GetEnumeratorTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);
            string actual = string.Join(", ", stack);
            actual.Should().Be("0, 1, 2, 3, 4, 5, 10");
        }

        [Test()]
        public void GetHashCodeTest()
        {
            SortedStack<int> stack1 = new(3, 1, 4, 5, 2, 0, 10);
            SortedStack<int> stack2 = new(4, 3, 1, 5, 2, 10, 0);
            SortedStack<int> stack3 = new(0, 1, 2, 3, 4, 5, 10);

            stack1.GetHashCode().Should().Be(stack2.GetHashCode());
            stack1.GetHashCode().Should().Be(stack3.GetHashCode());
            stack2.GetHashCode().Should().Be(stack3.GetHashCode());
        }

        [Test()]
        public void EqualsTest()
        {
            SortedStack<int> stack1 = new(3, 1, 4, 5, 2, 0, 10);
            SortedStack<int> stack2 = new(4, 3, 1, 5, 2, 10, 0);
            SortedStack<int> stack3 = new(0, 1, 2, 3, 4, 5, 11);
            SortedStack<int> stack4 = new(0, 1, 2, 3, 4, 5, 10, 9);

            stack1.Equals(stack2).Should().BeTrue();
            stack1.Equals(stack3).Should().BeFalse();
            stack1.Equals(stack4).Should().BeFalse();
            stack2.Equals(stack3).Should().BeFalse();
            stack3.Equals(stack4).Should().BeFalse();
        }

        [Test()]
        public void IndexerGetTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);

            stack[0].Should().Be(0);
            stack[1].Should().Be(1);
            stack[6].Should().Be(10);
        }

        [Test()]
        public void IndexOfTest()
        {
            SortedStack<int> stack = new(3, 1, 4, 5, 2, 0, 10);

            stack.IndexOf(0).Should().Be(0);
            stack.IndexOf(1).Should().Be(1);
            stack.IndexOf(10).Should().Be(6);
        }
    }
}