using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class Nesting
    {
        public static int IsNestingString(string S)
        {
            if (string.IsNullOrEmpty(S))
                return 1;

            while (S.IndexOf("()") >= 0)
            {
                S = S.Replace("()", string.Empty);
            }

            return S.Length > 0 ? 0 : 1;
        }
    }
}
