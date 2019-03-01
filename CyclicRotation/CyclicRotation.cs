using System;
using System.Linq;

namespace CyclicRotation
{
    public class Functions
    {
        public static int[] RotateTheArray(int[] A, int K)
        {
            var retval = new int[0] { };
            if (K == 0 || A.Length == 1)
                return A;
            if (A.Length == 0)
                return new int[0];

            var clonedArray = new int[A.Length];
            A.CopyTo(clonedArray, 0);
            for (int i = 1; i <= K; i++)
            {
                var tempArray = new int[A.Length];
                var lastElement = clonedArray.Last();
                tempArray[0] = lastElement;
                for (int item = 0; item < clonedArray.Length - 1; item++)
                {
                    tempArray[item + 1] = clonedArray[item];
                }
                tempArray.CopyTo(clonedArray, 0);
            }

            return clonedArray;
        }
    }
}
