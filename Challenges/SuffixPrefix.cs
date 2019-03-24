using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class SuffixPrefix
    {
        public static int CalculateString(string S)
        {
            if (string.IsNullOrEmpty(S))
                return 0;

            var suffixedList = new List<string> { string.Empty };
            for (int i = 0; i < S.Length; i++)
            {
                suffixedList.Add(S.Substring(0, i));
            }

            var prefixedList = new List<string> { string.Empty };
            for (int i = 1; i < S.Length; i++)
            {
                prefixedList.Add(S.Substring(S.Length - i, i));
            }

            var orderedList1 = prefixedList.OrderByDescending(x => x.Length).ToList();
            var orderedList2 = suffixedList.OrderByDescending(x => x.Length).ToList();

            for (int i = 0; i < orderedList1.Count; i++)
            {
                if (orderedList1[i] == orderedList2[i])
                {
                    return orderedList1[i].Length;
                }
            }
            
            return 0;
        }
    }
}
