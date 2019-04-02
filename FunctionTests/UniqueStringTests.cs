using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class UniqueStringTests
    {
        [Test]
        [TestCase("", false)]
        [TestCase("abc", true)]
        [TestCase("aa", false)]
        [TestCase("qwertyuıopğüasdfghjklşizxcvbnmöç", true)]
        [TestCase("qwertyuıopğüasdfghjklşizxcvbnmöçi", false)]
        public void IsAllUnique_WhenCalled_ShouldReturnDesiredResult(string str, bool desiredResult)
        {
            var result = Challenges.UniqueString.IsAllUnique(str);
            Assert.That(result, Is.EqualTo(desiredResult));
        }
    }
}
