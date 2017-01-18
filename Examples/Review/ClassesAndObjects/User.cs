using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class User : IComparable<User>, IEquatable<User>
    {
        public string Name { get; set; }

        public string Mail { get; set; }

        public int Age { get; set; }

        public User()
        { }

        public User(string name)
        {
            this.Name = name;
        }

        public User(string name, string email)
        {
            this.Name = name;
            this.Mail = email;
        }

        public User(string name, string email, int age)
        {
            this.Name = name;
            this.Mail = email;
            this.Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name:{0} Mail:{1} Age:{2}", this.Name, this.Mail, this.Age);
        }

        public string WriteUserToFileInSpecificFormat()
        {
            return string.Format("{0}|{1}|{2}", this.Name, this.Mail, this.Age);
        }

        public int CompareTo(User other)
        {
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age < other.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public bool Equals(User other)
        {
            return this.Age == other.Age;
        }
    }
}
