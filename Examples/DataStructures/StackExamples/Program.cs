using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1. Ivan");
            stack.Push("2. Nikolay");
            stack.Push("3. Maria");
            stack.Push("4. Emma");
            stack.Push("5. Adriana");
            Console.WriteLine("Top = " + stack.Peek());

            var arr = stack.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Contains("5. Adriana Lima"));

            while (stack.Count > 0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }

            PrintStack(stack);

            Console.WriteLine(stack.Count);
        }

        private static void PrintStack(Stack<string> stack)
        {
            Console.WriteLine(stack.Count);
        }
    }
}
