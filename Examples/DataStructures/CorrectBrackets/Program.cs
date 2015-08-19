using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression ="1 + (3 + 2 - (2+3) * 4 - ((3+1)*(4-2)))";
            Stack<int> stack = new Stack<int>();
            bool correctBrackets = true;
            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                {
                    stack.Push(index);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the brackets correct? " + correctBrackets);
        }
    }
}
