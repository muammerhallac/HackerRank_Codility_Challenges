using System;
using System.Linq;

namespace Challenges
{
    public class Dominator
    {
        public static object CalculateDominator(int[] A)
        {
            if (!A.Any())
                return -1;

            var indexNumber = -2;
            var dominatorCount = A.Count() / 2;
            var groupedItems = A.GroupBy(x => x);
            var dominatorGroup = groupedItems.Where(x => x.Count() > dominatorCount);
            if (dominatorGroup.Count() <= 0)
                return -1;
            indexNumber = Array.IndexOf(A, dominatorGroup.FirstOrDefault().Key);

            return indexNumber;
        }
    }
}
