using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        private string volHours;

        // additional property
        public string VolHours
        {
            get { return this.volHours; }
            set { this.volHours = value; }
        }


        //Constructor
        public Volunteer()
        {
            //default
        }

        public void FeedPet()
        {
            Console.WriteLine("You have fed the pet.");
        }

        public void WaterPet()
        {
            Console.WriteLine("You gav the pet water.");
        }

        public override void ClockIn()
        {
            Console.WriteLine("You have clocked in as a volunteer.");
        }
    }
}
