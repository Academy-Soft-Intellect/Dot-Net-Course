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
            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = 10; i < 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}
