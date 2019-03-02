using System;

namespace MissingInteger
{
    public class Functions
    {
        public static int FindMissingInteger(int[] A)
        {
            if (A.Length == 0)
                return 1;
            Array.Sort(A);
            int min = 1;
            foreach (var item in A)
            {
                if (item == min)
                {
                    min++;
                }
            }
            return min;
        }
    }
}
