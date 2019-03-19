using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class TwoCharactersTests
    {
        [Test]
        public void AlternateText_EmptyString_ReturnsZero()
        {
            var givenText = "";
            var alternatedText = Challenges.TwoCharacters.AlternateText(givenText);

            Assert.That(alternatedText, Is.EqualTo(0));
        }

        [Test]
        [TestCase("abaacdabd", 8)]
        public void AlternateText_GivenString_ReturnsLongestAlternate(string givenText, int desiredResult)
        {
            var alternatedText = Challenges.TwoCharacters.AlternateText(givenText);
            Assert.That(alternatedText, Is.EqualTo(desiredResult));
        }
    }
}
