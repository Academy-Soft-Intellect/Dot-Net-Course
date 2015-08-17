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

            Console.WriteLine(st);
        }
    }
}
