using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class MissingIntegerTests
    {
        [Test]
        public void FindMissingInteger_GivenEmptyArray_Returns1()
        {
            var result = MissingInteger.Functions.FindMissingInteger(new int[0] { });
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(new int[1] { 1 }, 2)]
        [TestCase(new int[2] { 2, 3 }, 1)]
        [TestCase(new int[5] { 6, 2, 3, 4, 1 }, 5)]
        public void FindMissingInteger_OneItemArray_ReturnsDesiredResult(int[] array, int desiredResult)
        {
            var result = MissingInteger.Functions.FindMissingInteger(array);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
