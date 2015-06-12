using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile("ttt.txt");
        }
        static void ReadFile(string filename)
        {
            TextReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
    }
}
