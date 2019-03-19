using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class MiniMaxSum
    {
        public static string CalculateMiniMaxSum(int[] arr)
        {
            var arrToList = arr.ToList().OrderBy(x => x);
            long miniSum = arrToList.Take(4).Aggregate((x, y) => x + y);

            arrToList = arrToList.OrderByDescending(x => x);
            long maxSum = arrToList.Take(4).Aggregate((a, b) => a + b);

            return string.Format("{0} {1}", miniSum, maxSum);
        }
    }
}
