using NUnit.Framework;

namespace FunctionTests
{
    [TestFixture]
    public class MiniMaxSumTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, "10 14")]
        [TestCase(new int[] { 10, 6, 3, 4, 11 }, "23 31")]
        [TestCase(new int[] { 45, 2, 6, 4, 55 }, "57 110")]
        [TestCase(new int[] { 5, 6, 3, 4, 5 }, "17 20")]
        public void CalculateMiniMaxSum_WhenCalled_ReturnsDesiredResult(int[] arr, string desiredResult)
        {
            var result = Challenges.MiniMaxSum.CalculateMiniMaxSum(arr);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
