using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionariesAndMaps
{
    public class Functions
    {
        public static string GetPhoneNumber(List<string> names, Dictionary<string, string> phoneBook)
        {
            if (!phoneBook.Any())
                return "Not found";

            var strBuilder = new StringBuilder();
            foreach (var item in names)
            {
                if (phoneBook.Keys.Any(x => x == item))
                {
                    var phoneNumber = string.Empty;
                    phoneBook.TryGetValue(item, out phoneNumber);
                    strBuilder.Append(string.Format("{0}={1}", item, phoneNumber));
                    strBuilder.Append(Environment.NewLine);
                }
                else
                {
                    strBuilder.Append("Not found");
                    strBuilder.Append(Environment.NewLine);
                }
            }

            return strBuilder.ToString();
        }
    }
}
