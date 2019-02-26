using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingValley
{
    public class Functions
    {
        public static int CountValley(string[] s)
        {
            var arrayToList = s.ToList();

            if (!arrayToList.Any())
                return 0;

            var currentPosition = 0;
            var previousPosition = 0;
            const int SeaLevel = 0;
            var valleyCount = 0;
            foreach (var item in arrayToList)
            {
                previousPosition = currentPosition;
                switch (item)
                {
                    case "D":
                        currentPosition += -1;
                        break;
                    case "U":
                        currentPosition += 1;
                        break;
                    default:
                        break;
                }
                
                if (previousPosition < SeaLevel && currentPosition >= SeaLevel)
                    valleyCount++;
            }

            return valleyCount;
        }
    }
}
