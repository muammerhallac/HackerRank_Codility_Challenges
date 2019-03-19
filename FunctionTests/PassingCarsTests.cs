using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Challenges;

namespace FunctionTests
{
    [TestFixture]
    public class PassingCarsTests
    {
        [Test]
        public void PassingCars_EmptyList_ShouldReturnMinus1()
        {
            var arr = new int[] { };
            var result = PassingCars.CountCars(arr);
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void PassingCars_AllGoingEast_ShouldReturnZero()
        {
            var arr = new int[] { 0, 0, 0, 0, 0 };
            var result = PassingCars.CountCars(arr);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void PassingCars_AllGoingWest_ShouldReturnZero()
        {
            var arr = new int[] { 1, 1, 1, 1, 1, 1 };
            var result = PassingCars.CountCars(arr);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new int[] { 0, 1, 0, 1, 1 }, 5)]
        [TestCase(new int[] { 0, 1 }, 1)]
        public void PassingCars_WhenCalled_ShouldReturnDesiredResult(int[] arr, int desiredResult)
        {
            var result = PassingCars.CountCars(arr);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
