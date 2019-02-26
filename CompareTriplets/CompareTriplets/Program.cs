using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CompareTriplets
{
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int> { };

            var alicePoint = 0;
            var bobPoint = 0;

            for (int i = 0; i < a.Count; i++)
            {
                var point1 = a.ElementAt(i);
                var point2 = b.ElementAt(i);

                if (point1 >= 1 && point1 <= 100 && point2 >= 1 && point2 <= 100)
                {
                    if (point1 > point2)
                    {
                        alicePoint = alicePoint + 1;
                    }
                    else if (point2 > point1)
                    {
                        bobPoint = bobPoint + 1;
                    }
                }
            }

            result.Add(alicePoint);
            result.Add(bobPoint);

            return result;
        }

        static void Main(string[] args)
        {
            var path = Environment.CurrentDirectory + "//result.txt";
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            TextWriter textWriter = new StreamWriter(path, true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
