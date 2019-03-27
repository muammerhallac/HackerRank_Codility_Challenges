using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class StringReversingTests
    {
        [Test]
        [TestCase("", "")]
        [TestCase("a", "a")]
        [TestCase("aa", "aa")]
        [TestCase("ab", "ba")]
        [TestCase("ab1", "1ba")]
        public void ReverseString_WhenCalled_ShouldReturnDesiredResult(string input, string desiredResult)
        {
            string result = Challenges.StringReversing.ReverseString(input);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
