using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindOddNumber
{
    public class Functions
    {
        public static int FinOddNumber(int[] array)
        {
            var retval = 0;
            var itemDictionary = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (itemDictionary.ContainsKey(array[i]))
                {
                    var currentItemValue = itemDictionary.GetValueOrDefault(array[i]);
                    currentItemValue++;

                    itemDictionary.Remove(array[i]);
                    itemDictionary.Add(array[i], currentItemValue);
                }
                else
                {
                    itemDictionary.Add(array[i], 1);
                }
            }

            if (itemDictionary.ContainsValue(1))
            {
                retval = itemDictionary.Where(x => x.Value == 1).Select(x => x.Key).FirstOrDefault();
            }
            return retval;
        }
    }
}
