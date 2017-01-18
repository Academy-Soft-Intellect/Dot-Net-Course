using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceFree
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter reader = new StreamWriter("test.txt");
            try
            {
                int a = int.Parse("sdad");
            }
            catch (Exception)
            {
            }
            finally
            {
                reader.Close();
            }
            Console.WriteLine();
        }
    }
}
