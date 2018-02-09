using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            string userInput;

            Volunteer newVolunteer = new Volunteer();
            Manager newManager = new Manager();
            VirtualPet newDog = new VirtualPet("Sirius", "Black dog, has human like intelligence.");
            VirtualPet newCat = new VirtualPet("Crookshanks", "Orange Cat, hates rats.");
            VirtualPet newToad = new VirtualPet("Trevor", "Green toad, often gets lost.");
            VirtualPet newOwl = new VirtualPet("Hedwig", "White owl, really likes mail.");

            Console.WriteLine("Welcome to the virtual pet shelter!");
            Console.WriteLine();
            

            //menu
            
            

                Console.WriteLine("Please select an option from the following:");
                Console.WriteLine("Press 1 to clock in");
                Console.WriteLine("Press 0 to clock out");


            do { 
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("If you would like to clock in as a volunteer, please type 'volunteer'");
                            Console.WriteLine("If you would like to clock in as a manager, please type 'manager'");
                            userInput = Console.ReadLine().ToLower();
                            if (userInput == "volunteer")
                            {
                                Console.WriteLine();
                                newVolunteer.ClockIn();
                                Console.WriteLine();
                                Console.Clear();
                                Console.WriteLine("Thank you for volunteering!");
                                Console.WriteLine("What would you like to do today?");
                                Console.WriteLine();
                                Console.WriteLine("Enter 'play' to take the pets on a walk.");
                                Console.WriteLine("Enter 'feed' to give the pets food.");
                                Console.WriteLine("Enter 'water' to give the pets water.");
                                Console.WriteLine("Enter 0 to clock out.");
                                Console.WriteLine();
                                userInput = Console.ReadLine().ToLower();

                                if (userInput == "play")
                                {
                                    newVolunteer.Play();
                                }
                                if (userInput == "feed")
                                {
                                    newVolunteer.FeedPet();
                                }
                                if (userInput == "water")
                                {
                                    newVolunteer.WaterPet();
                                }

                            }
                            if (userInput == "manager")
                            {
                                newManager.ClockIn();
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                                         
                           break;
                        }
                }

            } while (userChoice != 0);
            newManager.ClockOut();
        }
    }
}
