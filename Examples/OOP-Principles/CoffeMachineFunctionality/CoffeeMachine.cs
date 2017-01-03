using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachineFunctionality
{
    public class CoffeeMachine
    {
        private int WaterForCoffee { get; set; }

        private int BeansForCoffee { get; set; }

        public void MakeSmallCoffee()
        {
            this.WaterForCoffee = 10;
            this.BeansForCoffee = 10;

            this.HeatWater();
            this.PrepareCoffee();
        }

        public void MakeLargeCoffee()
        {
            this.WaterForCoffee = 20;
            this.BeansForCoffee = 20;

            this.HeatWater();
            this.PrepareCoffee();
        }


        private void HeatWater()
        {
            Console.WriteLine("Water heated");
        }

        private void PrepareCoffee()
        {
            Console.WriteLine(
                "Coffee prepared with {0} water and {1} beans", 
                this.WaterForCoffee, this.BeansForCoffee);
        }
    }
}
