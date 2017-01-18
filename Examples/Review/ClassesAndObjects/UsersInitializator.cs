using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public static class UsersInitializator
    {
        public static List<User> InitializeUsersList()
        {
            var usersList = new List<User>();

            usersList.Add(new User()
            {
                Mail = "first@user.com",
                Name = "FirstUser",
                Age = 25
            });

            usersList.Add(new User()
            {
                Mail = "second@user.com",
                Name = "SecondUser",
                Age = 35
            });

            usersList.Add(new User()
            {
                Mail = "third@user.com",
                Name = "ThirdUser",
                Age = 45
            });

            usersList.Add(new User()
            {
                Mail = "fourth@user.com",
                Name = "FourthUser",
                Age = 45
            });


            return usersList;
        }
    }
}
