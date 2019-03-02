using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class SuperReduceStringTests
    {
        [Test]
        public void ReduceString_WhenEmptyStringRepresented_ShouldReturnEmptyString()
        {
            var testString = string.Empty;
            var result = SuperReducedString.Functions.ReduceString(testString);
            Assert.That(result, Is.EqualTo("Empty String"));
        }

        [Test]
        [TestCase("aabba", "a")]
        [TestCase("aa", "Empty String")]
        [TestCase("bb", "Empty String")]
        [TestCase("bbbaaac", "bac")]
        public void ReduceString_WhenCalled_ShouldReturnExpectedResult(string testString, string expectedResult)
        {
            var result = SuperReducedString.Functions.ReduceString(testString);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
