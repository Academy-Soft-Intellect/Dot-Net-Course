using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //list.Add("Hello");
            //list.Add(5);
            //list.Add(3.14159);
            //list.Add(DateTime.Now);

            ////list.Sort();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    object value = list[i];
            //    Console.WriteLine(
            //    "Index={0}; Value={1}\n", i, value);
            //}


            LinkedList<int> test = new LinkedList<int>();
            LinkedListNode<int> beforeElement = new LinkedListNode<int>(3);

            for (int i = 0; i < 10; i++)
            {
                test.AddFirst(i);
            }

            test.AddFirst(beforeElement);
            test.AddAfter(beforeElement, 45);

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
