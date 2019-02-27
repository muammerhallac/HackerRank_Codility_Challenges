using System;

namespace FormingAMagicSquare
{
    public class Functions
    {
        static int residue(int[,] a, int[,] b)
        {
            return Math.Abs(a[0, 0] - b[0, 0]) + Math.Abs(a[0, 1] - b[0, 1]) + Math.Abs(a[0, 2] - b[0, 2]) +
                Math.Abs(a[1, 0] - b[1, 0]) + Math.Abs(a[1, 1] - b[1, 1]) + Math.Abs(a[1, 2] - b[1, 2]) +
                Math.Abs(a[2, 0] - b[2, 0]) + Math.Abs(a[2, 1] - b[2, 1]) + Math.Abs(a[2, 2] - b[2, 2]);
        }

        public static int Calculate(int[,] arr)
        {
            int[,] a = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                string line = Console.ReadLine();
                string[] fA = line.Split(' ');
                int j = 0;
                foreach (string num in fA)
                {
                    a[i, j] = Convert.ToInt32(num);
                    j++;
                }
            }
            int[,] c1 = new int[3, 3] { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } };
            int[,] c2 = new int[3, 3] { { 6, 1, 8 }, { 7, 5, 3 }, { 2, 9, 4 } };
            int[,] c3 = new int[3, 3] { { 8, 3, 4 }, { 1, 5, 9 }, { 6, 7, 2 } };
            int[,] c4 = new int[3, 3] { { 6, 7, 2 }, { 1, 5, 9 }, { 8, 3, 4 } };
            int[,] c5 = new int[3, 3] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
            int[,] c6 = new int[3, 3] { { 2, 9, 4 }, { 7, 5, 3 }, { 6, 1, 8 } };
            int[,] c7 = new int[3, 3] { { 4, 3, 8 }, { 9, 5, 1 }, { 2, 7, 6 } };
            int[,] c8 = new int[3, 3] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };

            int min = residue(a, c1);

            if (residue(a, c2) < min)
            {
                min = residue(a, c2);
            }
            if (residue(a, c3) < min)
            {
                min = residue(a, c3);
            }
            if (residue(a, c4) < min)
            {
                min = residue(a, c4);
            }
            if (residue(a, c5) < min)
            {
                min = residue(a, c5);
            }
            if (residue(a, c6) < min)
            {
                min = residue(a, c6);
            }
            if (residue(a, c7) < min)
            {
                min = residue(a, c7);
            }
            if (residue(a, c8) < min)
            {
                min = residue(a, c8);
            }

            return min;
        }
    }
}
