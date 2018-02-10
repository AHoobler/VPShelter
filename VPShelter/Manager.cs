using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        string petAdopt;
        //field
        private float salary;

        //property   
        public float Salary
        {
            get { return this.salary; }
        }

        //constructor??
        public Manager()
        {
            //default 
        }

        //adopt method
        public void Adopt()
        {
            Console.WriteLine();
            Console.WriteLine("Which pet would you like to find a home for?");
            Console.WriteLine("\n Sirius \n Crookshanks \n Trevor \n Hedwig");
            Console.WriteLine();
            petAdopt = Console.ReadLine().ToLower();

            switch (petAdopt)
            {
                case "sirius":            
                 Console.WriteLine("You found Sirius a home!");
                    Console.WriteLine();
                    return;

                case "crookshanks":
                   Console.WriteLine("You found Crookshanks a home!");
                    Console.WriteLine();
                    return;

                case "trevor":
                    Console.WriteLine("You found Trevor a home!");
                    Console.WriteLine();
                    return;

                case "Hedwig":
                    Console.WriteLine("You found a home for Hedwig");
                    Console.WriteLine();
                    return;
            }
            
        }

        public override void ClockIn()
        {
            Console.WriteLine();
            Console.WriteLine("You have clocked in as manager.");
        }



    }
}
