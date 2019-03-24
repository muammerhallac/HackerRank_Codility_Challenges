using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class SoldierRank
    {
        public static int CalculateRankCount(int[] ranks)
        {
            if (!ranks.Any())
            {
                return 0;
            }
            var rankCount = 0;
            var rankGroups = ranks.GroupBy(x => x);

            foreach (var item in rankGroups)
            {
                if (ranks.Contains(item.Key + 1))
                {
                    rankCount = rankCount+ item.Count();
                }
            }

            return rankCount;
        }
    }
}
