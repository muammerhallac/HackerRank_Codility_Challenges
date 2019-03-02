using System;
using System.Collections.Generic;
using System.Linq;

namespace TapeEquilibrium
{
    public class TapeEquilibriumCalculation
    {
        public static int Calculate(int[] A, int pairCount)
        {
            if (A.Length == 0)
            {
                return 0;
            }

            var pairSums = new List<int>();
            for (int i = 1; i <= pairCount; i++)
            {
                var firstPartTotal = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    firstPartTotal += A[j];
                }

                var secondPartTotal = 0;
                for (var k = i; k <= A.Length - 1; k++)
                {
                    secondPartTotal += A[k];
                }

                pairSums.Add(Math.Abs(firstPartTotal - secondPartTotal));
            }

            return pairSums.OrderBy(x => x).FirstOrDefault();
        }
    }
}
