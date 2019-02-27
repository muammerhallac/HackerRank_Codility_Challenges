using System;

namespace FormingAMagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] row0 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] row1 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int[] row2 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int diff = Math.Abs(row0[0] - 4)
                + Math.Abs(row0[1] - 9)
                + Math.Abs(row0[2] - 2)
                + Math.Abs(row1[0] - 3) 
                + Math.Abs(row1[1] - 5) 
                + Math.Abs(row1[2] - 7) 
                + Math.Abs(row2[0] - 8) 
                + Math.Abs(row2[1] - 1) 
                + Math.Abs(row2[2] - 6);

            int min = diff;
            diff = Math.Abs(row0[0] - 2) + Math.Abs(row0[1] - 7) + Math.Abs(row0[2] - 6) +
                 Math.Abs(row1[0] - 9) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 1) +
                 Math.Abs(row2[0] - 4) + Math.Abs(row2[1] - 3) + Math.Abs(row2[2] - 8);
            if (diff < min)
            {
                min = diff;
            }
            diff = Math.Abs(row0[0] - 6) + Math.Abs(row0[1] - 1) + Math.Abs(row0[2] - 8) +
                 Math.Abs(row1[0] - 7) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 3) +
                 Math.Abs(row2[0] - 2) + Math.Abs(row2[1] - 9) + Math.Abs(row2[2] - 4);
            if (diff < min)
            {
                min = diff;
            }
            diff = Math.Abs(row0[0] - 8) + Math.Abs(row0[1] - 3) + Math.Abs(row0[2] - 4) +
                 Math.Abs(row1[0] - 1) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 9) +
                 Math.Abs(row2[0] - 6) + Math.Abs(row2[1] - 7) + Math.Abs(row2[2] - 2);
            if (diff < min)
            {
                min = diff;
            }
            diff = Math.Abs(row2[0] - 4) + Math.Abs(row2[1] - 9) + Math.Abs(row2[2] - 2) +
                      Math.Abs(row1[0] - 3) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 7) +
                      Math.Abs(row0[0] - 8) + Math.Abs(row0[1] - 1) + Math.Abs(row0[2] - 6);
            if (diff < min)
            {
                min = diff;
            }
            diff = Math.Abs(row2[0] - 2) + Math.Abs(row2[1] - 7) + Math.Abs(row2[2] - 6) +
                 Math.Abs(row1[0] - 9) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 1) +
                 Math.Abs(row0[0] - 4) + Math.Abs(row0[1] - 3) + Math.Abs(row0[2] - 8);
            if (diff < min)
            {
                min = diff;
            }
            diff = Math.Abs(row2[0] - 6) + Math.Abs(row2[1] - 1) + Math.Abs(row2[2] - 8) +
                 Math.Abs(row1[0] - 7) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 3) +
                 Math.Abs(row0[0] - 2) + Math.Abs(row0[1] - 9) + Math.Abs(row0[2] - 4);
            if (diff < min)
            {
                min = diff;
            }
            diff = Math.Abs(row2[0] - 8) + Math.Abs(row2[1] - 3) + Math.Abs(row2[2] - 4) +
                 Math.Abs(row1[0] - 1) + Math.Abs(row1[1] - 5) + Math.Abs(row1[2] - 9) +
                 Math.Abs(row0[0] - 6) + Math.Abs(row0[1] - 7) + Math.Abs(row0[2] - 2);
            if (diff < min)
            {
                min = diff;
            }
            Console.WriteLine(min);
        }
    }
}
