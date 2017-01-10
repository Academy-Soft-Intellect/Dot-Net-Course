using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> numbers = new List<int>();

            //for (int i = 0; i < 11; i++)
            //{
            //    numbers.Add(i);
            //}
            //Console.WriteLine(numbers.Capacity);
            //Console.WriteLine(numbers.Count);

            //var evenNumbers = numbers.Where(number => number % 2 == 0);
            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //numbers.Add(45);

            //numbers.Add(12);
            //numbers.Add(12);
            //numbers.Add(12);
            //numbers.Add(12);
            //numbers.Add(12);

            //Console.WriteLine(numbers.Capacity);
            //Console.WriteLine(numbers.Count);

            List<Student> students = new List<Student>();
            for (int i = 0; i < 15; i++)
            {
                //var current = new Student();
                //current.Name = Console.ReadLine();
                //current.Age = int.Parse(Console.ReadLine());
                //students.Add(current);

                students.Add(new Student()
                {
                    Name = string.Format("Student " + i),
                    Age = i
                });
            }

            students.RemoveAt(5);

            students.Insert(8, new Student() { Name = "Newly inserted student", Age = 26 });

            var studentToRemove = students[6];

            students.Remove(studentToRemove);

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }

        }
    }
}
