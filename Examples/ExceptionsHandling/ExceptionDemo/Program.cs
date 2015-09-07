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
            int a = int.Parse(Console.ReadLine());
            //ReadFile("ttt.txt");
        }
        static void ReadFile(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
    }
}
