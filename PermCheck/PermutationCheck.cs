using System;
using System.Linq;

namespace PermCheck
{
    public class PermutationCheck
    {
        public static int IsPermutation(int[] A)
        {
            if (A.Length == 0 || A.Length == 1)
                return 0;

            Array.Sort(A);
            decimal sumOfArray = A.Aggregate((item1, item2) => item1 + item2);
            decimal lastElement = A.Last();
            decimal actualTotal = (lastElement * (lastElement + 1)) / 2;

            return sumOfArray == actualTotal ? 1 : 0;
        }
    }
}