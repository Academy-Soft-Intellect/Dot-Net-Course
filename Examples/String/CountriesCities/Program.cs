using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesCities
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("countries.txt"))
            {
                using (StreamWriter writer = new StreamWriter("cities.txt"))
                {
                    string line = reader.ReadLine();

                    while (line!=null && line != string.Empty)
                    {
                        Console.WriteLine("Please enter the capitol of : " + line);

                        writer.WriteLine(Console.ReadLine());

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
