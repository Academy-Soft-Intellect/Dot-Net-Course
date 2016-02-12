using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pesho Georgiev Dimitrov";

            string[] names = name.Split(new string[] {"Georg" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
