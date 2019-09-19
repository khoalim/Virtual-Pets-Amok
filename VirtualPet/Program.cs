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
                Console.WriteLine("2. Feed Pet");
                Console.WriteLine("3. Play with Pet");
                Console.WriteLine("4. Take Pet to Doctor");
                Console.WriteLine("5. View Info of All Shelter Pets");
                Console.WriteLine("6. View Status of All Shelter Pets");
                Console.WriteLine("7. Feed All Pets");
                Console.WriteLine("8. Play with All Pets");
                Console.WriteLine("9. Maintain All Pets");
                Console.WriteLine("10. Adopt a Pet");
                Console.WriteLine("11. Exit Game");

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
                        string petType = Console.ReadLine().ToLower();

                        if (petType == "a")
                        {
                            VirtualPet organicPet = new OrganicPets();
                            organicPet.AddPet(name, species);
                            shelter.AddPetToShelter(organicPet);

                        }
                        else
                        {
                            VirtualPet roboticPet = new RoboticPets();
                            roboticPet.AddPet(name, species);
                            shelter.AddPetToShelter(roboticPet);

                        }                                                
                        Console.WriteLine("\nYou've added a pet to the Shelter!");                        
                        break;

                    

                    case "2":
                        Console.WriteLine("\nYou've fed your pet!");
                        virtualPet = SelectPetMenu(shelter);
                        virtualPet.FeedPet();
                        break;

                    case "3":
                        Console.WriteLine("\nThanks for playing with me!");
                        virtualPet  = SelectPetMenu(shelter);
                        virtualPet.PlayPet();
                        break;

                    case "4":
                        Console.WriteLine("\nYour pet's maintenance is A-Okay!");
                        virtualPet = SelectPetMenu(shelter);
                        virtualPet.MaintainPet();
                        break;

                    case "5":
                        Console.WriteLine("\nChecking all pets info...");

                        //VirtualPet petChoiceInfo = SelectPetMenu(shelter);
                        shelter.DisplayInfoList();
                        break;

                    case "6":
                        Console.WriteLine("\nChecking all pets status...");
                        shelter.DisplayStatusList();
                        break;

                    case "7":
                        Console.WriteLine("\nYou've fed all your pets!");
                        shelter.FeedAllPets();
                        break;                    

                    case "8":
                        Console.WriteLine("\nThanks for playing with all your pets!");
                        shelter.PlayAllPets();
                        break;

                    case "9":
                        Console.WriteLine("\n The doctor says all your pets are A-Okay!");
                        shelter.DoctorAllPets();
                        break;

                    case "10":
                        VirtualPet petChoice = SelectPetMenu(shelter);
                        shelter.RemovePet(petChoice);                        
                        break;

                        
                    case "11":
                        inMenu = false;
                        Console.WriteLine("\nSee yah!");
                        break;
                }
                               
            }

            while (inMenu);
        }

        static VirtualPet SelectPetMenu(Shelter shelter)
        {
            Console.WriteLine("\nPlease select a pet:");
            int virtualPetNumber = 1;
            foreach (VirtualPet shelterPet in shelter.ShelterPets)
            {
                Console.WriteLine($"{virtualPetNumber}. {shelterPet.Name}, {shelterPet.Species}, {shelterPet.Type}");
                virtualPetNumber++;
            }
            int selectedvirtualPetNumber = Convert.ToInt32(Console.ReadLine());
                     

            return shelter.ShelterPets[selectedvirtualPetNumber - 1];
        }

        
    }
}
            


         
           
        
    


