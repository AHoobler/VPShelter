using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
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
            Console.WriteLine("You found a home for the pet!");
        }

        public override void FeedPet()
        {
            Console.WriteLine("You got paid to feed the pet!");
        }



    }
}
