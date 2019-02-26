using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;

namespace BinaryGaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var userListWithEvenId = FilterById(PrepareData());
            Console.WriteLine(userListWithEvenId.ToList().Count);
        }

        private static List<User> PrepareData()
        {
            var userList = new List<User>();
            for (int i = 1; i <= 1000000; i++)
            {
                userList.Add(new User { Id = i, Username = $"Username_{i}" });
            }

            return userList;
        }

        private static IEnumerable<User> FilterById(IEnumerable<User> userList)
        {
            foreach (var item in userList)
            {
                if (item.Id % 2 == 0)
                    yield return item;
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
