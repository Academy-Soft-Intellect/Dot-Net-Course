using ClassesAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //KeyValuePair<string, string> arr = new KeyValuePair<string, string>();

            List<User> usersList = new List<User>();

            //for (int i = 0; i < 5; i++)
            //{
            //    usersList.Add(new User()
            //    {
            //        Mail = Console.ReadLine(),
            //        Name = Console.ReadLine()
            //    });
            //}

            usersList = UsersInitializator.InitializeUsersList();

            var usersOlderThanThirty = usersList.Where(x => x.Mail.Contains("second")).ToList();

            var averageYears = usersList.Average(u => u.Age);

            Console.WriteLine("Average years: " + averageYears);

            foreach (var item in usersOlderThanThirty)
            {
                Console.WriteLine(item);
            }

            var maxYears = usersList.Max(u => u.Age);
            var oldestUser = usersList.First(u => u.Age == maxYears);
            Console.WriteLine("Oldest user is:");
            Console.WriteLine(oldestUser);
        }
    }
}
