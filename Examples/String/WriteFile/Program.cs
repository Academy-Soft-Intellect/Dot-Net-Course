using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("test.txt", true))
            {
                writer.WriteLine("This");

                writer.WriteLine("is");

                writer.WriteLine("test");
            }
        }
    }
}
