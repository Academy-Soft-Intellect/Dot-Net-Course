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
            ReadFile("ttt.txt");
        }

        static void ReadFile(string filename)
        {
            TextReader reader = TextReader.Null;
            try
            {
                reader = new StreamReader(filename);
                string line = reader.ReadLine();
                Console.WriteLine(line);
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
                if (reader != TextReader.Null)
                {
                    reader.Close();
                }
                Console.WriteLine("Exception handling passed!");
            }
        }
    }
}
