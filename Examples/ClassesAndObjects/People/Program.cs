using MyFirstClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ben = new Person();
            ben.Name = "Benjamin";
            ben.Age = 20;
            ben.Email = "ben@benjamin.com";
            ben.PrintInfo();

            Person john = new Person();
            john.Name = "Johnathan";
            john.Age = 22;
            john.Email = "john@hohnathan.com";
            john.PrintInfo();

            Person jack = new Person();
            jack.Name = "Jack Daniels";
            jack.Age = 200;
            jack.Email = "jack@jackson.com";
            jack.PrintInfo();

        }
    }
}
