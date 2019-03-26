using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class NestingTests
    {
        [Test]
        [TestCase("", 1)]
        [TestCase("())", 0)]
        [TestCase("()", 1)]
        [TestCase("(())", 1)]
        [TestCase("(()(())())",1)]
        [TestCase("((())(())(()))", 1)]
        public void IsNestingString_WhenCalled_ShouldReturnDesiredResult(string S, int desiredResult)
        {
            int result = Challenges.Nesting.IsNestingString(S);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
