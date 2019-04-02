using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class UniqueString
    {
        public static bool IsAllUnique(string theString)
        {
            if (string.IsNullOrEmpty(theString))
                return false;

            int repeatLetterCount = 0;
            theString.ToList().ForEach(x =>
            {
                if (theString.Where(a => a == x).Count() > 1)
                    repeatLetterCount++;
            });

            return repeatLetterCount == 0;
        }
    }
}
