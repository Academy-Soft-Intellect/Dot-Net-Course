using ClassesAndObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        private const string _filePath = "users.txt";

        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                var usersList = UsersInitializator.InitializeUsersList();

                foreach (var item in usersList)
                {
                    writer.WriteLine(item.WriteUserToFileInSpecificFormat());
                }
            }

            var readUsersList = ReadUsersFromFileAndCreateList();

            foreach (var item in readUsersList)
            {
                Console.WriteLine(item);
            }
        }

        private static List<User> ReadUsersFromFileAndCreateList()
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                var line = reader.ReadLine();
                var usersList = new List<User>();

                while (line != null && line !=string.Empty)
                {
                    var userInfo = line.Split('|');

                    usersList.Add(new User()
                    {
                        Name = userInfo[0],
                        Mail = userInfo[1],
                        Age = int.Parse(userInfo[2])
                    });

                    line = reader.ReadLine();
                }
                return usersList;
            }
        }
    }
}
