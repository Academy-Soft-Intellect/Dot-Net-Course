using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile("ttt.txt");
        }

        static void ReadFile(string filename)
        {
            try
            {
                TextReader reader = new StreamReader(filename);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("The file '{0}' is not found.", filename);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
            finally
            {
                Console.WriteLine("Exception handling passed!");
            }

        }
    }
}
