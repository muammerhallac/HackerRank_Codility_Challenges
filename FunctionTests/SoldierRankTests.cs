using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class SoldierRankTests
    {
        [Test]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 3, 4, 3, 0, 2, 2, 3, 0, 0 }, 5)]
        [TestCase(new int[] { 4, 2, 0 }, 0)]
        [TestCase(new int[] { 4, 4, 3, 3, 1, 0 }, 3)]
        public void CalculateRankCount_WhenCalled_ShouldReturnDesiredResult(int[] ranks, int desiredResult)
        {
            var result = Challenges.SoldierRank.CalculateRankCount(ranks);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
