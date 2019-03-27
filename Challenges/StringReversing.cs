using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class StringReversing
    {
        public static string ReverseString(string input)
        {
            if (input == "")
                return input;

            //var charArray = input.ToCharArray();
            //Array.Reverse(charArray);

            //return new string(charArray);

            var reversedString = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + input[i];
            }

            return reversedString;
        }
    }
}
