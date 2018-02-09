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
       public virtual void ClockIn()
        {
            Console.WriteLine("You have clocked in for the day");
        }

        public virtual void ClockOut()
        {
            Console.WriteLine("You have clocked out for the day");
        }

        public virtual void Play()
        {
            Console.WriteLine("You took the pets for a walk!");
        }
    }
}
