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
            VirtualPet newDog = new VirtualPet("Sirius", "Black dog, has human like intelligence.",12,15,10);
            VirtualPet newCat = new VirtualPet("Crookshanks", "Orange Cat, hates rats.",10,4,3);
            VirtualPet newToad = new VirtualPet("Trevor", "Green toad, often gets lost.",7,9,10);
            VirtualPet newOwl = new VirtualPet("Hedwig", "White owl, really likes mail.",5,13,7);

            Console.WriteLine("Welcome to the virtual pet shelter!");
            Console.WriteLine();
            

            //menu
            
            

                Console.WriteLine("Please select an option from the following:");
                Console.WriteLine("Press 1 to clock in as volunteer.");
                Console.WriteLine("Press 2 to clock in as manager. ");
                Console.WriteLine("Press 0 to clock out");


            do { 
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            newVolunteer.ClockIn();
                            Console.WriteLine("Thank you for volunteering!");
                            do
                            {
                                Console.WriteLine();
                                Console.WriteLine("What volunteer task would you like to complete?");
                                Console.WriteLine("Enter 'play' to take the pets on a walk.");
                                Console.WriteLine("Enter 'feed' to give the pets food.");
                                Console.WriteLine("Enter 'water' to give the pets water.");
                                Console.WriteLine("Enter 'leave' to clock out.");
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

                            } while (userInput != "leave");
                            newVolunteer.ClockOut();
                        }break;

                    case 2:
                        {
                            Console.Clear();
                            newManager.ClockIn();
                            Console.WriteLine();

                            do
                            {
                                Console.WriteLine("What manager task would you like to complete?");
                                Console.WriteLine("Enter 'adopt' to set up and adoption.");
                                Console.WriteLine("Enter 'Play' to take the pets on a walk.");
                                Console.WriteLine("Enter 'leave' to clock out.");
                                Console.WriteLine();

                                userInput = Console.ReadLine().ToLower();
                                
                                if (userInput == "adopt" )
                                {
                                    newManager.Adopt();
                                }
                                if (userInput == "play")
                                {
                                    newManager.Play();
                                }
                            } while (userInput != "leave");
                        }break; 
                }

            } while (userChoice != 0);
            newManager.ClockOut();
        }
    }
}
