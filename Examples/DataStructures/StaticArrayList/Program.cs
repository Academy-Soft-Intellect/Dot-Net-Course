﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList carPartsList = new CustomArrayList();
            carPartsList.Add("Tires");
            carPartsList.Add("Oil");
            carPartsList.Add("Sway bar");
            carPartsList.Add("Brakes");
            carPartsList.Remove("Oil");
            Console.WriteLine("We need to buy:");
            for (int i = 0; i < carPartsList.Count; i++)
            {
                Console.WriteLine(carPartsList[i]);
            }
            Console.WriteLine("Do we have to buy Tires? " +
            carPartsList.Contains("Tires"));
        }
    }
}
