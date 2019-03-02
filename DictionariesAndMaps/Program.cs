using System;
using System.Collections.Generic;
using System.Text;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, string>();
            var namesToBeChecked = new List<string>();
            var times = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                var namePhonePair = Console.ReadLine();
                var key = namePhonePair.Split(' ')[0];
                var value = namePhonePair.Split(' ')[1];
                phoneBook.Add(key, value);
            }

            for (int i = 0; i < times; i++)
            {
                var name = Console.ReadLine();
                namesToBeChecked.Add(name);
            }

            Console.WriteLine(Functions.GetPhoneNumber(namesToBeChecked, phoneBook));
        }
    }
}
