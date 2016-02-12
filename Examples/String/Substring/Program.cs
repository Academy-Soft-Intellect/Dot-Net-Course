using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pesho Petrov Dimitrov";

            //string surname = name.Substring(6, 8);

            string surname = name.Substring(name.IndexOf(" ") + 1,
                name.LastIndexOf(" ") - (name.IndexOf(" ") + 1));

            Console.WriteLine(surname +"//");
        }
    }
}
