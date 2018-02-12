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
            VirtualPet newDog = new VirtualPet("Sirius", "Black dog who has human like intelligence.",25,22,20);
            VirtualPet newCat = new VirtualPet("Crookshanks", "Orange Cat who hates rats.",50,40,92);
            VirtualPet newToad = new VirtualPet("Trevor", "Green toad who often gets lost.",20,46,76);
            VirtualPet newOwl = new VirtualPet("Hedwig", "White owl who really likes mail.",55,83,67);

            // fixed
            //newCat.Name = "Crookshanks ";
            //newDog.Name = "Sirius ";
            //newOwl.Name = "Hedwig ";
            //newToad.Name = "Trevor ";
            //newCat.Description = " Orange cat who hates rats.";
            //newDog.Description = " Black dog with human like intelligence.";
            //newToad.Description = " Green toad who gets lost easily.";
            //newOwl.Description = " White owl who really like mail.";


            Console.WriteLine("Welcome to the virtual pet shelter!");
            Console.WriteLine();
            

            // main menu

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
                                //volunteer menu
                                Console.WriteLine("Current pet values");
                                Console.WriteLine("| Name        | Hunger | Thirst   | Boredom |");
                                Console.WriteLine("| Sirius      | " + newDog.IsHungry + "     | " +  newDog.IsThirsty + "       | " + newDog.IsBored + "      | " );
                                Console.WriteLine("| CrookShanks | " + newCat.IsHungry + "     | " + newCat.IsThirsty + "       | " + newCat.IsBored + "      | ");
                                Console.WriteLine("| Trevor      | " + newToad.IsHungry + "     | " + newToad.IsThirsty + "       | " + newToad.IsBored+ "      | " );
                                Console.WriteLine("| Hedwig      | " + newOwl.IsHungry + "     | " + newOwl.IsThirsty + "       | " + newOwl.IsBored + "      | ") ;
                                Console.WriteLine();
                                Console.WriteLine("What volunteer task would you like to complete?");
                                Console.WriteLine("Enter 'play' to play with the pets.");
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
                                    newCat.IsHungry--;
                                    newDog.IsHungry--;
                                    newOwl.IsHungry--;
                                    newToad.IsHungry--;
                                    newVolunteer.FeedPet();
                                }
                                if (userInput == "water")
                                {
                                    newCat.IsThirsty--;
                                    newDog.IsThirsty--;
                                    newOwl.IsThirsty--;
                                    newToad.IsThirsty--;
                                    newVolunteer.WaterPet();
                                }

                            } while (userInput != "leave");
                            newVolunteer.ClockOut();                    
                        }return;

                    case 2:
                        {
                            Console.Clear();
                            newManager.ClockIn();
                            Console.WriteLine();

                            do
                            {   //manager menu
                                Console.WriteLine("What manager task would you like to complete?");
                                Console.WriteLine("Enter 'adopt' to set up and adoption.");
                                Console.WriteLine("Enter 'play' to play with the pets.");
                                Console.WriteLine("Enter 'leave' to clock out.");
                                Console.WriteLine();

                                userInput = Console.ReadLine().ToLower();
                                
                                // pet name and descriptions
                                if (userInput == "adopt" )
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Here are the pets available for adoption.");
                                    Console.WriteLine(newDog.Name + " is a " + newDog.Description);
                                    Console.WriteLine(newCat.Name + " is an " + newCat.Description);
                                    Console.WriteLine(newOwl.Name + " is a " + newOwl.Description);
                                    Console.WriteLine(newToad.Name + " is a " + newToad.Description);
                                    Console.WriteLine();
                                    newManager.Adopt();
                                }
                                if (userInput == "play")
                                {
                                    newManager.Play();
                                }
                            } while (userInput != "leave");
                            newManager.ClockOut();
                        }return; 
                }

            } while (userChoice != 0);
            newManager.ClockOut();
        }
    }
}
