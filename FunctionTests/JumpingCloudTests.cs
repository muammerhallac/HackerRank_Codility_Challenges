using NUnit.Framework;
using JumpingOnTheClouds;

namespace FunctionTests
{
    public class JumpingCloudTests
    {
        [Test]
        public void CalculateJumpCount_EmptyArray_ShouldReturnZero()
        {
            var testArray = new int[] { };
            var result = Functions.CalculateJumpableClouds(testArray);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateJumpCount_OneItemArrayStartsWith0_ShouldReturnZero()
        {
            var testArray = new int[] { 0 };
            var result = Functions.CalculateJumpableClouds(testArray);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateJumpCount_OneItemArrayStartsWith1_ShouldReturnZero()
        {
            var testArray = new int[] { 1 };
            var result = Functions.CalculateJumpableClouds(testArray);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new int[] { 0, 0 }, 1)]
        public void CalculateJumpCount_TwoItemsArrayWhenCalled_ShouldReturnExpectedResult(int[] arr, int expectedResult)
        {
            var result = Functions.CalculateJumpableClouds(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 0, 0, 0 }, 1)]
        [TestCase(new int[] { 0, 1, 0 }, 1)]
        public void CalculateJumpCount_MoreThan2ItemsArrayWhenCalled_ShouldReturnExpectedResult(int[] arr, int expectedResult)
        {
            var result = Functions.CalculateJumpableClouds(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new int[] { 0, 0, 1, 0 }, 2)]
        [TestCase(new int[] { 0, 0, 1, 0, 1, 0, 0, 0, 0 }, 5)]
        public void CalculateJumpCount_MoreThan3ItemsArrayWhenCalled_ShouldReturnExpectedResult(int[] arr, int expectedResult)
        {
            var result = Functions.CalculateJumpableClouds(arr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}