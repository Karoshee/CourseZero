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
        [TestCase(2, 1)]
        [TestCase(2, 3)]
        [TestCase(21, 3)]
        [TestCase(-123124, 120)]
        [TestCase(122, -6)]
        [TestCase(-1892, -5)]
        public void RemainderTest(int num, int div)
        {
            var actual = HomeworkTasks.Remainder(num, div);
            var expected = num % div;
            actual.Should().Be(expected);
        }

        [Test]
        public void AverangeTest()
        {
            decimal[] numbers = new[] { 12.2M, 5M, 23M, 9.01M, 101.2M, 91M };
            var actual = HomeworkTasks.Averange(numbers);
            var expected = numbers.Average();
            actual.Should().Be(expected, "исходный массив { 12.2, 5, 23, 9.01, 101.2, 91 }");
        }

        [TestCase(true)]
        [TestCase(false)]
        public void SortTest(bool isAccendant)
        {
            int[] numbers = new[] {1, 12, 7, 213, 1, 0, -1, 23,-20, 21, 1, 0, 1234 };
            int[] actual = HomeworkTasks.Sort(numbers, isAccendant);
            int[] expected;
            if (isAccendant)
                expected = numbers.OrderBy(x => x).ToArray();
            else
                expected = numbers.OrderByDescending(x => x).ToArray();
            actual.Should().BeEquivalentTo(expected, "исходный массив: {1, 12, 7, 213, 1, 0, -1, 23,-20, 21, 1, 0, 1234 }");
        }

        [Test()]
        public void InvertTest()
        {
            const string input = "mofdszp";
            var actual = HomeworkTasks.Invert(input);
            const string expected = "pzsdfom";
            actual.Should().Be(expected, "исходная строка: " + input);
        }

        [Test()]
        public void InvertCaseTest()
        {
            const string input = "ЯаЗвяыЕКвЯКз";
            var actual = HomeworkTasks.InvertCase(input);
            const string expected = "яАзВЯЫекВякЗ";
            actual.Should().Be(expected, "исходная строка: " + input);
        }

        [Test()]
        public void IntersectTest()
        {
            var arr1 = new int[] { 1, 2, 4, 5, 6, 7, 8 };
            var arr2 = new int[] { 2, 5, 0, -1, 3, 10, 18, 1 };
            var actual = HomeworkTasks.Intersect(arr1, arr2);
            actual.Should().HaveCount(4);
            actual.Should().Contain(1);
            actual.Should().Contain(2);
            actual.Should().Contain(3);
            actual.Should().Contain(5);
         }

        [TestCase("XII", 12)]
        [TestCase("X", 10)]
        [TestCase("IX", 9)]
        [TestCase("VIII", 8)]
        [TestCase("IV", 4)]
        [TestCase("II", 2)]
        [TestCase("X", 10)]
        [TestCase("IL", 49)]
        [TestCase("LIII", 53)]
        [TestCase("IC", 99)]
        [TestCase("CII", 102)]
        [TestCase("C", 100)]
        [TestCase("ID", 499)]
        [TestCase("DII", 502)]
        [TestCase("M", 1000)]
        [TestCase("IM", 999)]
        public void RomanToIntegerTest(string roman, int expected)
        {
            var actual = HomeworkTasks.RomanToInteger(roman);
            actual.Should().Be(expected);
        }
    }
}