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
                Console.WriteLine("\nEnter Number of Menu Option");
                Console.WriteLine("\n1. Add Pet");
                Console.WriteLine("2. View Current Pet Info");
                Console.WriteLine("3. View Current Pet Status");
                Console.WriteLine("4. Feed Pet");
                Console.WriteLine("5. Play with Pet");
                Console.WriteLine("6. Take Pet to Doctor");
                Console.WriteLine("7. View Info of All Shelter Pets");
                Console.WriteLine("8. View Status of All Shelter Pets");
                Console.WriteLine("9. Feed All Pets");
                Console.WriteLine("10. Play with All Pets");
                Console.WriteLine("11. Take All Pets to Doctor");
                Console.WriteLine("12. Exit Game");

                Console.WriteLine(); // <---This is here to add some space between the menu and the user's input

                string petMenuChoice = Console.ReadLine();

                switch (petMenuChoice)
                {
                    case "1":
                                              
                       Console.WriteLine("\nType your pet's name  below:");
                       string name = Console.ReadLine();
                       
                       
                        Console.WriteLine("\nType your pet's species below:");
                        string species = Console.ReadLine();
                        
                        
                        Console.WriteLine("\nEnter A for an organic pet or B for a robotic pet");
                        string newType = Console.ReadLine().ToLower();

                        virtualPet = new VirtualPet();
                        VirtualPet organicPets = new OrganicPets();
                        VirtualPet roboticPets = new RoboticPets();
                        virtualPet.AddPet(name, species, newType);

                        shelter.AddPetToShelter(virtualPet);

                        
                        Console.WriteLine("\nYou've added a pet to the Shelter!");                        
                        break;

                    case "2":
                        Console.WriteLine("\nChecking your pet's info....");                        
                        virtualPet.GetInfo();
                        break;


                    case "3":
                        Console.WriteLine("\nChecking your pet's status...");
                        virtualPet.CheckStatus();
                        break;

                    case "4":
                        Console.WriteLine("\nYou've fed your pet!");
                        virtualPet.FeedPet();
                        break;

                    case "5":
                        Console.WriteLine("\nThanks for playing with me!");
                        virtualPet.PlayPet();
                        break;

                    case "6":
                        Console.WriteLine("\nThe doctor says your pet is A-Okay!");
                        virtualPet.DoctorPet();
                        break;

                    case "7":
                        Console.WriteLine("\nChecking all pets info...");
                        shelter.DisplayInfoList();
                        break;

                    case "8":
                        Console.WriteLine("\nChecking all pets status...");
                        shelter.DisplayStatusList();
                        break;

                    case "9":
                        Console.WriteLine("\nYou've fed all your pets!");
                        shelter.FeedAllPets();
                        break;

                    case "10":
                        Console.WriteLine("\nThanks for playing with all your pets!");
                        shelter.PlayAllPets();
                        break;

                    case "11":
                        Console.WriteLine("\n The doctor says all your pets are A-Okay!");
                        shelter.DoctorAllPets();
                        break;                 

                    case "12":
                        inMenu = false;
                        Console.WriteLine("\nSee yah!");
                        break;
                }
                               
            }

            while (inMenu);
        }    
    }
}
            


         
           
        
    


