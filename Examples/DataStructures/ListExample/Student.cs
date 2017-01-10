using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    public class Student : IEquatable<Student>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Equals(Student other)
        {
            return this.Name == other.Name && this.Age == other.Age;
        }
    }
}
