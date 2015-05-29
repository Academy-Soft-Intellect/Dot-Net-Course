using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "aaa";
            string str2 = "aaa";
            Console.WriteLine(str1 == str2);

            StreamReader reader = new StreamReader("asdadsa");


            reader.ReadToEnd()
        }
    }
}
