using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class CyclicRotationTests
    {
        [Test]
        [TestCase(new int[0] { }, 0, new int[0] { })]
        [TestCase(new int[1] { 1 }, 0, new int[1] { 1 })]
        [TestCase(new int[1] { 1 }, 10, new int[1] { 1 })]
        [TestCase(new int[2] { 1, 2 }, 0, new int[2] { 1, 2 })]
        [TestCase(new int[2] { 1, 2 }, 1, new int[2] { 2, 1 })]
        [TestCase(new int[2] { 1, 2 }, 2, new int[2] { 1, 2 })]
        [TestCase(new int[2] { 1, 2 }, 3, new int[2] { 2, 1 })]
        [TestCase(new int[2] { 1, 2 }, 4, new int[2] { 1, 2 })]
        [TestCase(new int[3] { 1, 2, 3 }, 0, new int[3] { 1, 2, 3 })]
        [TestCase(new int[3] { 1, 2, 3 }, 1, new int[3] { 3, 1, 2 })]
        [TestCase(new int[3] { 1, 2, 3 }, 2, new int[3] { 2, 3, 1 })]
        [TestCase(new int[3] { 1, 2, 3 }, 3, new int[3] { 1, 2, 3 })]
        [TestCase(new int[3] { 1, 2, 3 }, 4, new int[3] { 3, 1, 2 })]
        public void RotateTheArray_WhenCalled_ShouldReturnDesiredResult(int[] givenArray, int times, int[] desiredResult)
        {
            var result = CyclicRotation.Functions.RotateTheArray(givenArray, times);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
