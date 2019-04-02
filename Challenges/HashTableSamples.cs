using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class HashTableSamples
    {
        public void SampleOne()
        {
            var hashTable = new Hashtable();
            hashTable.Add(1, "1");
            hashTable.Add("1", 1);
        }
    }
}
