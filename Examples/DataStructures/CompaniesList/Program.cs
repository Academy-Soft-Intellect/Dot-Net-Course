using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> companiesList = new List<Company>();

            companiesList.Add(new Company
            {
                Name = "First Company",
                NumberOfEmployees = 5
            });

            companiesList.Add(new Company
            {
                Name = "Second Company",
                NumberOfEmployees = 15
            });

            companiesList.Add(new Company
            {
                Name = "Third Company",
                NumberOfEmployees = 25
            });

            int maxEmployess = companiesList[0].NumberOfEmployees;
            Company temp = companiesList[0];
            foreach (var item in companiesList)
            {
                if (maxEmployess < item.NumberOfEmployees)
                {
                    maxEmployess = item.NumberOfEmployees;
                    temp = item;
                }
            }

            companiesList.Remove(temp);

            companiesList.Add(new Company
            {
                Name = "Fourth Company with longest name",
                NumberOfEmployees = 15
            });

            companiesList.Add(new Company
            {
                Name = "Fifth Company",
                NumberOfEmployees = 25
            });

            string longestName = companiesList[0].Name;
            temp = companiesList[0];
            int index = 0;
            foreach (var item in companiesList)
            {
                if (longestName.Length < item.Name.Length)
                {
                    longestName = item.Name;
                    temp = item;
                    index = companiesList.IndexOf(item);
                }
            }

            companiesList.Insert(index, new Company
            {
                Name = "Sixth Company",
                NumberOfEmployees = 25
            });

            companiesList.RemoveAt(index + 1);

            foreach (var item in companiesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
