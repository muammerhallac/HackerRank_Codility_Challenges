using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class DominatorTests
    {
        [Test]
        [TestCase(new int[] { }, -1)]
        [TestCase(new int[] { 1, 2 }, -1)]
        [TestCase(new int[] { 1, 1 }, 0)]
        public void CalculateDominator_WhenCalled_ShouldReturnDesiredResult(int[] arr, int desiredResult)
        {
            var result = Challenges.Dominator.CalculateDominator(arr);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
