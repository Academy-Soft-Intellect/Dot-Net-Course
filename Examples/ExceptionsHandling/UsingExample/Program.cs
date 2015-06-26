using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            using (StreamWriter reader = new StreamWriter(path))
            {
                using (StreamWriter reader2 = new StreamWriter(path))
                {
                    reader2.WriteLine("Test");

                }
                
            }
        }
    }
}
