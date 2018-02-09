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
            Console.WriteLine("Sirius \n Crookshanks \n Trevor \n Hedwig");
            petAdopt = Console.ReadLine().ToLower();

            if (petAdopt == "sirius") ;
            {

            }


        }

        public override void ClockIn()
        {
            Console.WriteLine();
            Console.WriteLine("You have clocked in as manager.");
        }



    }
}
