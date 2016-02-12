using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("../../obj/test3.txt"))
                {
                    int start = Environment.TickCount;
                    string line = reader.ReadLine();
                    int lineNumber = 0;
                    while (line != null)
                    {
                        lineNumber++;
                        //Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                    Console.WriteLine(lineNumber);
                    Console.WriteLine(Environment.TickCount - start);
                    string text = reader.ReadToEnd();

                    //Console.WriteLine(text);
                    Console.WriteLine(Environment.TickCount - start);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File was not found");
            }
            
        }
    }
}
