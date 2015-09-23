using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseTeamsForTeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = (new string[] { "Atanas", "Andrey", "Alexander", "Liubomir", "Ivaylo", "Kiril", "Pavel", "Megi", "Radoslav" }).ToList();

            Random rand = new Random();
            int i = 1;

            while (i<=3)
            {
                Console.WriteLine("Team " + i + ":");
                for (int j = 0; j < 3; j++)
                {
                    int index = rand.Next(0, names.Count());
                    Console.WriteLine(names[index]);
                    names.RemoveAt(index);
                }
                i++;
                Console.WriteLine();
            }

        }
    }
}
