using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    public class TwoCharacters
    {
        public static int AlternateText(string givenText)
        {
            if (string.IsNullOrEmpty(givenText))
            {
                return 0;
            }

            //Get distinct letters
            var stringLetters = new List<string> { };
            givenText.ToCharArray().ToList().ForEach(x =>
            {
                if (!stringLetters.Contains(x.ToString()))
                {
                    stringLetters.Add(x.ToString());
                }
            });

            //Prepare letter pairs
            var stringPairs = new List<string> { };
            for (int i = 0; i < stringLetters.Count; i++)
            {
                var currentLetter = stringLetters.ElementAt(i);
                for (int j = i + 1; j < stringLetters.Count; j++)
                {
                    var nextLetter = stringLetters.ElementAt(j);
                    if (!string.IsNullOrEmpty(nextLetter))
                    {
                        stringPairs.Add(string.Format("{0}{1}", currentLetter, nextLetter));
                    }
                }
            }

            //Alternate string
            var alternatedStrings = new List<string> { };

            foreach (var item in stringPairs)
            {
                var alternatedText = givenText;
                var itemArray = item.ToArray();
                for (int i = 0; i < itemArray.Length; i++)
                {
                    alternatedText = alternatedText.Replace(itemArray[i].ToString(), string.Empty);
                    alternatedStrings.Add(alternatedText);
                }
            }

            return alternatedStrings.Max(x => x.Length);
        }

        public static int Enumerate()
        {

            IReadOnlyCollection<string> list = new List<string> { "string1", "string2" };
            var listCount = list.Count;
            return listCount;
        }

        public virtual int Asas()
        {
            return 1;
        }
    }
}
