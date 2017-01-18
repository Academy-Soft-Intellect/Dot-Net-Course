using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //User[] usersList = new User[2];

            //for (int i = 0; i < usersList.Count(); i++)
            //{
            //    usersList[i] = new User();
            //    usersList[i].Mail = Console.ReadLine();
            //    usersList[i].Name = Console.ReadLine();
            //}

            //foreach (var item in usersList)
            //{
            //    Console.WriteLine(item);
            //}

            var secondUsersList = UsersInitializator.InitializeUsersList();

            //CompareUsers(secondUsersList);

            AreUsersEqual(secondUsersList);
        }

        private static void AreUsersEqual(List<User> secondUsersList)
        {
            Console.WriteLine(secondUsersList[2].Equals(secondUsersList[3]));
        }

        private static void CompareUsers(List<User> secondUsersList)
        {
            var result = secondUsersList[2].CompareTo(secondUsersList[1]);

            Console.WriteLine(result);
        }
    }
}
