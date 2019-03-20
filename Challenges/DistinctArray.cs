using System;
using System.Linq;

namespace Challenges
{
    public class DistinctArray
    {
        public static int GroupArray(int[] A)
        {
            return A.GroupBy(x => x).Count();
        }
    }
}