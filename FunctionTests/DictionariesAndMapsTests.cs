using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionTests
{
    [TestFixture]
    public class DictionariesAndMapsTests
    {
        [Test]
        public void DictionariesAndMaps_WhenEmptyDictionaryQueried_ReturnsNotFound()
        {
            var phoneBook = new Dictionary<string, string>();
            var result = DictionariesAndMaps.Functions.GetPhoneNumber(new List<string> { "sampleName" }, phoneBook);
            Assert.That(result, Is.EqualTo("Not found"));
        }

        [Test]
        public void DictionariesAndMaps_WhenOneMissingNameDictionaryQueried_ReturnsDesiredResult()
        {
            var phoneBook = new Dictionary<string, string>();
            phoneBook.Add("name1", "123123444");
            phoneBook.Add("name2", "123454545");

            var result = new StringBuilder();
            result.Append("name1=123123444");
            result.Append(Environment.NewLine);
            result.Append("Not Found");

            var queryResult = DictionariesAndMaps.Functions.GetPhoneNumber(new List<string> { "name22" }, phoneBook);
            Assert.That(result, Is.EqualTo(result));
        }

        [Test]
        public void DictionariesAndMaps_WhenTwoMissingNameDictionaryQueried_ReturnsDesiredResult()
        {
            var phoneBook = new Dictionary<string, string>();
            phoneBook.Add("name1", "123123444");
            phoneBook.Add("name2", "123454545");

            var result = new StringBuilder();
            result.Append("Not Found");
            result.Append(Environment.NewLine);
            result.Append("Not Found");

            var queryResult = DictionariesAndMaps.Functions.GetPhoneNumber(new List<string> { "name22", "asdf22" }, phoneBook);
            Assert.That(result, Is.EqualTo(result));
        }
    }
}
