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
            using (StreamReader reader = new StreamReader(""))
            {
                using (StreamWriter writer = new StreamWriter("numbers.txt", true))
                {
                    for (int i = 1; i < 20; i++)
                    {
                        writer.Write(i);
                    }
                }
            }
        }
    }
}
