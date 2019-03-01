using FindOddNumber;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class FindOddNumberTests
    {
        [Test]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 1, 1, 3 }, 3)]
        [TestCase(new int[] { 1, 1, 3, 1, 3 }, 1)]
        public void FindOddNumber_WhenCalled_ShouldReturnExpectedResult(int[] array, int expectedResult)
        {
            var result = Functions.FinOddNumber(array);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
