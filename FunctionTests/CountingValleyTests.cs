using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class CountingValleyTests
    {
        [Test]
        public void CountValley_EmptyArray_ShouldReturnZero()
        {
            var testArray = new string[] { };
            var result = CountingValley.Functions.CountValley(testArray);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new string[] { "D", "D", "D" }, 0)]
        [TestCase(new string[] { "D", "D", "D", "U" }, 0)]
        [TestCase(new string[] { "D", "D", "D", "U", "U" }, 0)]
        [TestCase(new string[] { "D", "D", "D", "U", "U", "U" }, 1)]
        [TestCase(new string[] { "D", "U", "D", "U", "D", "U" }, 3)]
        public void CountValley_WhenCalled_ShouldReturnExpectedResult(string[] arr, int expectedResult)
        {
            var result = CountingValley.Functions.CountValley(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new string[] { "U", "D", "D", "D", "U", "D", "U", "U" }, 1)]
        public void CountValley_WhenCalledSpecialArray_ShouldReturnExpectedResult(string[] arr, int expectedResult)
        {
            var result = CountingValley.Functions.CountValley(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
