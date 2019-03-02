using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class TapeEquilibriumCalculationTests
    {
        [Test]
        public void Calculate_WhenEmptyArrayGiven_ReturnsZero()
        {
            var result = TapeEquilibrium.TapeEquilibriumCalculation.Calculate(new int[0] { }, 5);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new int[5] { 3, 1, 2, 4, 3 }, 4, 1)]
        [TestCase(new int[6] { 3, 1, 2, 4, 3, 7 }, 5, 0)]
        [TestCase(new int[6] { 3, 1, 2, 4, 3, 5 }, 5, 2)]
        public void Calculate_WhenCalled_ReturnsDesiredResult(int[] array, int pairCount, int desiredResult)
        {
            var result = TapeEquilibrium.TapeEquilibriumCalculation.Calculate(array, pairCount);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
