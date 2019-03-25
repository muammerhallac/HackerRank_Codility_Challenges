using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class FishTests
    {
        [Test]
        [TestCase(new int[] { 5, 1 }, new int[] { 0, 0 }, 2)]
        [TestCase(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0, }, 2)]
        public void FishLunch_WhenCalled_ShouldReturnDesiredResult(int[] A, int[] B, int desiredResult)
        {
            var result = Challenges.Fish.FishLunch(A, B);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
