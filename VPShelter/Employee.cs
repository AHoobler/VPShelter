using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //field
        private int employeeID;


        // one property
        public int EmployeeID
        { 
        get { return employeeID; }
        }


        // no constructor in abstract class

        // two abstract methods
       public virtual void FeedPet()
        {
            Console.WriteLine("You fed the pet");
        }

        public virtual void WaterPet()
        {
            Console.WriteLine("You gave the pet water");
        }
    }
}
