using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class SuffixPrefixTests
    {
        [Test]
        [TestCase("abbabba", 7)]
        public void CalculateSuffixPrefix_WhenCalled_ShouldReturnDesiredResult(string S, int desiredResult)
        {
            var result = Challenges.SuffixPrefix.CalculateString(S);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
