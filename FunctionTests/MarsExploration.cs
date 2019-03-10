using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class MarsExploration
    {
        [Test]
        [TestCase("", 0)]
        [TestCase("SOSSPSSQSSOR", 3)]
        [TestCase("SOSSOT", 1)]
        [TestCase("FADDAFFQWEEE", 12)]
        [TestCase("SOSSOSSOS", 0)]
        [TestCase("SOSOSOSOSDSDSKWOSDOSDOASDOASDFAFJDFDOSOSOWNSOSOSNDSKDDOSOSOSJDSDSOOSOSDSDOSASSOASDSAOSOSODSDSOASDWS", 67)]
        public void CalculateAlteredMessage_WhenCalled_ReturnsDesiredResult(string theMessage, int desiredResult)
        {
            var result = Challenges.MarsExploration.CalculateAlteredMessage(theMessage);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
