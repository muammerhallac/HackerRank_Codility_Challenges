using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public static class PassingCars
    {
        public static int CountCars(int[] A)
        {
            if (!A.Any())
                return -1;

            var carPairs = 0;
            var goingEastCarCount = A.Where(x => x == 0).ToList();
            var goingWestCarCount = A.Where(x => x == 1).ToList();

            if (!goingEastCarCount.Any() || !goingWestCarCount.Any())
                return 0;

            for (int i = 0; i < A.Length; i++)
            {
                switch (A[i])
                {
                    case 0:
                        var carCountGoingWest = A.Skip(i).Take(A.Length - i).Where(x => x == 1).Count();
                        carPairs += carCountGoingWest;
                        break;
                    case 1:
                        var carCountGoingEast = A.Take(i).Where(x => x == 0).Count();
                        carPairs += carCountGoingEast;
                        break;
                    default:
                        break;
                }
            }
            if (carPairs >= 1000000000)
                return -1;

            return carPairs / 2;
        }
    }
}
