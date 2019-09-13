using System;
using System.Collections.Generic;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)

            
        {
            VirtualPet virtualPet = new VirtualPet();
            Shelter shelter = new Shelter();
            

            Console.WriteLine("Welcome to Virtual Pets Place!");

            bool inMenu = true;

            do
            {
                Console.WriteLine("\nWhat would you like to do next?");
                Console.WriteLine("\n1. Add Pet");
                Console.WriteLine("2. Name Pet");
                Console.WriteLine("3. Select Pet Species");
                Console.WriteLine("4. View Pet Info");
                Console.WriteLine("5. View Pet Status");
                Console.WriteLine("6. Feed Pet");
                Console.WriteLine("7. Play with Pet");
                Console.WriteLine("8. Take Pet to Doctor");
                Console.WriteLine("9. Exit Game");

                Console.WriteLine(); // <---This is here to add some space between the menu and the user's input

                string petMenuChoice = Console.ReadLine();

                switch (petMenuChoice)
                {
                    case "1":
                                              
                       Console.WriteLine("\nType your pet's name  below:");
                       string name = Console.ReadLine();
                       //virtualPet.GetName(name);
                       
                        Console.WriteLine("\nType your pet's species below:");
                        string species = Console.ReadLine();
                        //virtualPet.GetSpecies(species);
                        virtualPet.AddPet(name, species);

                        shelter.AddPetToShelter(virtualPet);



                        Console.WriteLine("\nYou've added a pet to the Shelter!");                        
                        break;

                    case "4":
                        Console.WriteLine("\nChecking your pet's info....");
                        
                        virtualPet.GetInfo();
                        break;


                    case "5":
                        Console.WriteLine("\nChecking your pet's status...");
                        virtualPet.CheckStatus();
                        break;

                    case "6":
                        Console.WriteLine("\nYou've fed your pet!");
                        virtualPet.FeedPet();
                        break;

                    case "7":
                        Console.WriteLine("\nThanks for playing with me!");
                        virtualPet.PlayPet();
                        break;

                    case "8":
                        Console.WriteLine("\nThe doctor says your pet is A-Okay!");
                        virtualPet.DoctorPet();
                        break;

                    case "9":
                        inMenu = false;
                        Console.WriteLine("\nSee yah!");
                        break;
                }
                               
            }

            while (inMenu);
        }    
    }
}
            


         
           
        
    


