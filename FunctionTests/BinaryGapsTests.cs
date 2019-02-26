using BinaryGaps;
using NUnit.Framework;

namespace FunctionTests
{
    [TestFixture]
    public class BinaryGapsTests
    {
        [Test]
        [TestCase("", 0)]
        [TestCase("0", 0)]
        [TestCase("1", 0)]
        [TestCase("100", 0)]
        [TestCase("1001", 2)]
        [TestCase("100101", 2)]
        [TestCase("10000010001", 5)]
        [TestCase("1001001", 2)]
        public void CalculateBinaryGaps_WhenCalled_ShouldReturnExpectedResult(string binaryStr, int expectedResult)
        {
            var result = Functions.CalculateBinaryGaps(binaryStr);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
