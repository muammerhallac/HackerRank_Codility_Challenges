using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class BracketsTests
    {
        [Test]
        [TestCase("", 0)]
        [TestCase("()[", 0)]
        [TestCase("()", 1)]
        [TestCase("[]", 1)]
        [TestCase("{}", 1)]
        [TestCase("([])", 1)]
        [TestCase("{[()()]}", 1)]
        [TestCase("([)()]", 0)]
        public void IsNested_WhenCalled_ShouldReturnDesiredResult(string S, int desiredResult)
        {
            var result = Challenges.Brackets.IsNested(S);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}