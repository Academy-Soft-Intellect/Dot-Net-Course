using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComaprableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<Student, string> dict = new SortedDictionary<Student, string>();

            dict.Add(new Student() {
                Age = 20,
                Name = "Student 1"
            }, "sdadsa");
            dict.Add(new Student() {
                Age = 15,
                Name = "Student 2"
            }, "sdadsa");
            dict.Add(new Student() {
                Age = 7,
                Name = "Student 3"
            }, "sdadsa");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.Name);
            }
        }
    }
}
