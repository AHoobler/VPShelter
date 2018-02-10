using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        string petPlay;
        string readLet;
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
            Console.WriteLine("Which pet would you like to play with?");
            Console.WriteLine("\n Sirius \n Crookshanks \n Trevor \n Hedwig");
            Console.WriteLine();
            petPlay = Console.ReadLine().ToLower();

            switch (petPlay)
            {
                case "sirius":
                    
                    Console.WriteLine("You took Sirius for a walk!");
                    Console.WriteLine("He tried to escape from you multiple times!");
                    Console.WriteLine();
                    return;

                case "crookshanks":
                    Console.WriteLine("You and Crookshanks played with a ball of yarn!");
                    Console.WriteLine();
                    return;

                case "trevor":
                    Console.WriteLine("You lost Trevor when you took him out of the cage.");
                    Console.WriteLine();
                    Console.WriteLine(" :( ");
                    Console.WriteLine();
                    return;

                case "hedwig":
                    Console.WriteLine("You let Hedwig out to fly!");
                    Console.WriteLine("Hedwig brought back a letter!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to read the letter? Please type 'yes' or 'no'.");
                    Console.WriteLine();
                    readLet = Console.ReadLine().ToLower();

                    if (readLet == "yes")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Harry, \n I'm trapped in a cage with a strange man. Please send help! \n -padfoot.");
                        Console.WriteLine();
                        Console.WriteLine("What a strange letter. I wonder what it means.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You put the letter in the recycling.");
                    }
                    Console.WriteLine();
                    return;
            }

        }
    }
}
