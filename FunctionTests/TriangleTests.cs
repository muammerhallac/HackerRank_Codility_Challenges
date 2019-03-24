using Challenges;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void IsTriangle_EmptyArray_ShouldReturnZero()
        {
            var result = Triangle.IsTriangle(new int[] { });
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void IsTriangle_LessThan3ItemArray_ShouldReturnZero()
        {
            var result = Triangle.IsTriangle(new int[] { 1, 2 });
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 2, 2, 3 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 6 }, 0)]
        [TestCase(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [TestCase(new int[] { 10, 50, 5, 1 }, 0)]
        public void IsTriangle_MoreThan3ItemArray_ShouldReturnDesiredResult(int[] A, int desiredResult)
        {
            var result = Triangle.IsTriangle(A);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}


