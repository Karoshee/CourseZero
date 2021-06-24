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

        [TestCase(12, 4.32321f, "0012 4,3232 21.01.2020(20:33:41)")]
        [TestCase(15322, 4.32f, "15322 4,3200 21.01.2020(20:33:41)")]
        public void FormatTest(int num, float flNum, string expected)
        {
            DateTime dt = new DateTime(2020, 1, 21, 20, 33, 41);
            var actual = HomeworkTasks.Format(num, flNum, dt);
            actual.Should().Be(expected);
        }

        [TestCase(1, 2, 3, 4, ExpectedResult = 4)]
        [TestCase(1, 5, 3, 4, ExpectedResult = 5)]
        [TestCase(1, 2, 6, 4, ExpectedResult = 6)]
        [TestCase(10, 2, 3, 4, ExpectedResult = 10)]
        public int MaxTest(int n1, int n2, int n3, int n4)
        {
            return HomeworkTasks.Max(n1, n2, n3, n4);
        }

        [TestCase("jufzjfajff", ExpectedResult = 'f')]
        [TestCase("0001102012210", ExpectedResult = '0')]
        public char MostCommonCharTest(string str)
        {
            return HomeworkTasks.MostCommonChar(str);
        }

        [TestCase("f7d72h92h2923hd9", ExpectedResult ="7729229239")]
        [TestCase("123421131", ExpectedResult ="123421131")]
        [TestCase("fdjaklzwvczf", ExpectedResult ="")]
        public string NumbersOnlyTest(string input)
        {
            return HomeworkTasks.NumbersOnly(input);
        }
    }
}