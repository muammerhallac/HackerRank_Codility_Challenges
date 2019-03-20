using NUnit;
using NUnit.Framework;

namespace FunctionTests
{
    [TestFixture]
    public class DistinctArrayTests
    {
        [Test]
        [TestCase(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
        [TestCase(new int[] { 2, 1, 1, 2, 3, 1, 4 }, 4)]
        public void GroupArray_WhenCalled_ShouldReturnDesiredResult(int[] arr, int desiredResult)
        {
            var result = Challenges.DistinctArray.GroupArray(arr);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}