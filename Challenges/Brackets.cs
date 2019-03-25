using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class Brackets
    {
        public static int IsNested(string S)
        {
            if (string.IsNullOrEmpty(S) || S.Length % 2 != 0)
                return 0;

            var firstPartOfString = S.Substring(0, S.Length / 2);
            var secondPartOfString = S.Substring(S.Length / 2, S.Length / 2);
            var mismatchParts = new Stack<int>();
            var reversedSecondPart = secondPartOfString.ToCharArray();
            Array.Reverse(reversedSecondPart);

            for (int i = 0; i < firstPartOfString.Length; i++)
            {
                var currentCharacter = firstPartOfString[i];
                switch (currentCharacter)
                {
                    case '(':
                        if (reversedSecondPart[i] != ')')
                            mismatchParts.Push(1);
                        break;
                    case '[':
                        if (reversedSecondPart[i] != ']')
                            mismatchParts.Push(1);
                        break;
                    case '{':
                        if (reversedSecondPart[i] != '}')
                            mismatchParts.Push(1);
                        break;
                    case ')':
                        if (reversedSecondPart[i] != '(')
                            mismatchParts.Push(1);
                        break;
                    case ']':
                        if (reversedSecondPart[i] != '[')
                            mismatchParts.Push(1);
                        break;
                    case '}':
                        if (reversedSecondPart[i] != '{')
                            mismatchParts.Push(1);
                        break;
                    default:
                        break;
                }
            }

            return mismatchParts.Count > 0 ? 0 : 1;
        }
    }
}
