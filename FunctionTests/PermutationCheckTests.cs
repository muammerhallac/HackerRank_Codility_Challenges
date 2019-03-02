using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class PermutationCheckTests
    {
        [Test]
        public void IsPermutation_GivenAnEmptyArray_ReturnsFalse()
        {
            var result = PermCheck.PermutationCheck.IsPermutation(new int[0] { });
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new int[1] { 1 }, 0)]
        [TestCase(new int[2] { 1, 2 }, 1)]
        [TestCase(new int[3] { 1, 2, 3 }, 1)]
        [TestCase(new int[3] { 4, 3, 1 }, 0)]
        [TestCase(new int[5] { 4, 3, 5, 1, 2 }, 1)]
        [TestCase(new int[5] { 6, 5, 2, 1, 4 }, 0)]
        public void IsPermutation_WhenCalled_ReturnsDesiredResult(int[] array, int desiredResult)
        {
            var result = PermCheck.PermutationCheck.IsPermutation(array);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
