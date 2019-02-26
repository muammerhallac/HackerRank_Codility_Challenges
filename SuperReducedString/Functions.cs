using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperReducedString
{
    public class Functions
    {
        public static string ReduceString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "Empty String";

            var charGroups = s.ToList().GroupBy(x => x).ToList();
            var tempString = s;
            foreach (var item in charGroups)
            {
                var stringToReplace = string.Empty;
                if (item.Count() % 2 == 0)
                {
                    stringToReplace = string.Format("{0}", item.Key);
                    for (int i = 0; i < item.Count(); i++)
                    {
                        tempString = tempString.Replace(stringToReplace, string.Empty);
                    }
                }
                else
                {
                    stringToReplace = string.Format("{0}{1}", item.Key, item.Key);
                    for (int i = 0; i < item.Count(); i = i + 2)
                    {
                        tempString = tempString.Replace(stringToReplace, string.Empty);
                    }
                }
            }

            return string.IsNullOrEmpty(tempString) ? "Empty String" : tempString;
        }
    }
}
    