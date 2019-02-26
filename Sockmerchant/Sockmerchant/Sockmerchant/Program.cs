using System;
using System.IO;
using System.Collections;

namespace Sockmerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            var totalPairs = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (i < n && ar[i] == ar[i+1])
                {
                    totalPairs++;
                    i++;
                }
            }

            return totalPairs;
        }

        static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory + "//output.txt";
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            TextWriter textWriter = new StreamWriter(path, true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            Console.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
