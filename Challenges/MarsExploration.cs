using System;
using System.Linq;

namespace Challenges
{
    public class MarsExploration
    {
        public static int CalculateAlteredMessage(string theMessage)
        {
            if (string.IsNullOrEmpty(theMessage))
                return 0;
            const int chunkSize = 3;
            const string originalMessage = "SOS";
            var stringChunks = Enumerable.Range(0, theMessage.Length / chunkSize)
                .Select(c => theMessage.Substring(c * chunkSize, chunkSize)).ToList();

            var changedLetterCount = 0;
            foreach (var stringChunk in stringChunks)
            {
                for (int i = 0; i < stringChunk.Length; i++)
                {
                    if (stringChunk[i] != originalMessage.ToArray()[i])
                    {
                        changedLetterCount++;
                    }
                }
            }

            return changedLetterCount;
        }
    }
}
