using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class Fish
    {
        public static int FishLunch(int[] A, int[] B)
        {
            if (!A.Any() || !B.Any())
                return 0;

            var upStreamFishes = new Stack<int>();
            var downStreamFishes = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 0) //upstream fish
                {
                    if (downStreamFishes.Any())
                    {
                        while (downStreamFishes.Any() && downStreamFishes.Peek() < A[i])
                        {
                            downStreamFishes.Pop();
                        }

                        if (!downStreamFishes.Any())
                        {
                            upStreamFishes.Push(A[i]);
                        }
                    }
                    else
                        upStreamFishes.Push(A[i]);
                }
                else
                    downStreamFishes.Push(A[i]);
            }

            return upStreamFishes.Count + downStreamFishes.Count;
        }
    }
}
