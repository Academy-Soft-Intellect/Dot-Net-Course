using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person()
        {
            count++;
        }

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            count++;
        }


        public void PrintInfo()
        {
            Console.WriteLine("{0} is {1} old. His/her email is {2}!",name, age, email);
        }
    }
}
