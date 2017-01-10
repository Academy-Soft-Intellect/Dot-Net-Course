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
            //numbers.Add(45);

            //numbers.Add(12);
            //numbers.Add(12);
            //numbers.Add(12);
            //numbers.Add(12);
            //numbers.Add(12);

            //Console.WriteLine(numbers.Capacity);
            //Console.WriteLine(numbers.Count);

            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                var current = new Student();
                current.Name = Console.ReadLine();
                current.Age = int.Parse(Console.ReadLine());
                students.Add(current);

                //students.Add(new Student()
                //{
                //    Name = string.Format("Student " + i),
                //    Age = i
                //});
            }
            var st = new Student()
            {
                Name = "Student 4",
                Age = 4
            };

            int maxEmpployees = 0;
            int indexToDelete = 0;

            foreach (var item in students)
            {
                if (item.Age > maxEmpployees)
                {
                    maxEmpployees = item.Age;
                    indexToDelete = students.IndexOf(item);
                }
            }
            students.RemoveAt(indexToDelete);

            students.RemoveAt(5);
            Console.WriteLine(students.IndexOf(st));
            students.Remove(st);
            foreach (var student in students)
            {
                Console.WriteLine(string.Format("{0} is {1} years old", student.Name, student.Age));
            }

        }
    }
}
