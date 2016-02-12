using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComaprableDemo
{
    class Student : IComparable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (this.Age > (obj as Student).Age)
            {
                return 1;
            }
            else if (this.Age < (obj as Student).Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
