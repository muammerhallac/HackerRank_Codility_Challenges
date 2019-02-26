using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpingOnTheClouds
{
    public class Functions
    {
        public static int? CalculateJumpableClouds(int[] cloudArray)
        {
            int? retval = null;
            var cloudCount = cloudArray.Length;
            if (cloudArray.Length <= 1)
                retval = 0;

            if (cloudArray.Length == 2 || cloudArray.Length == 3)
                retval = 1;

            int noOfJumps = 0, i = 0;
            while (true)
            {
                if (i + 2 < cloudCount && cloudArray[i + 2] == 0)
                {
                    i += 2;
                }
                else if (i + 1 < cloudCount)
                {
                    i++;
                }
                else
                {
                    break;
                }
                noOfJumps++;
            }
            retval = noOfJumps;

            return retval;
        }
    }
}
