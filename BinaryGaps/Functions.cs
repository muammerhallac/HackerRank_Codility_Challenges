using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryGaps
{
    public class Functions
    {
        public static int CalculateBinaryGaps(string binaryString)
        {
            if (string.IsNullOrEmpty(binaryString) || binaryString.Length <= 2)
                return 0;

            var isGapStarted = false;
            char previousItem = new char();
            var stringList = binaryString.ToList();
            var currentGapLength = 0;
            var gaps = new List<int>();
            foreach (var item in stringList)
            {
                if (item == '0' && previousItem == '1')
                    isGapStarted = true;

                if (item == '1' && isGapStarted)
                {
                    gaps.Add(currentGapLength);
                    isGapStarted = false;
                    currentGapLength = 0;
                }

                if (item == '0' && isGapStarted)
                    currentGapLength++;
                
                previousItem = item;
            }

            return gaps.OrderByDescending(x => x).FirstOrDefault();
        }
    }
}
