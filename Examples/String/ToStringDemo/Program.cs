using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Name = "Az";
            st.Family = "Sum";
            st.FacultyNumber = 123;
            st.Group = "AK-47";

            Student st2 = new Student();
            st2.Name = "Az";
            st2.Family = "Sum";
            st2.FacultyNumber = 1234;
            st2.Group = "AK-47";

            Console.WriteLine(st);
            Console.WriteLine(st.Equals(st2));
        }
    }
}
