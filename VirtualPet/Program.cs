using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)

            
        {
            VirtualPet virtualPet = new VirtualPet();

            Console.WriteLine("Welcome to Virtual Pets Place!");

            bool inMenu = true;

            do
            {
                Console.WriteLine("\n1. Add Pet");
                Console.WriteLine("2. Name Pet");
                Console.WriteLine("3. Select Pet Species");
                Console.WriteLine("4. View Pet Info");
                Console.WriteLine("5. View Pet Status");
                Console.WriteLine("6. Feed Pet");
                Console.WriteLine("7. Play with Pet");
                Console.WriteLine("8. Take Pet to Doctor");
                Console.WriteLine("9. Exit Game");

                string petMenuChoice = Console.ReadLine();

                switch (petMenuChoice)
                {
                    case "1":
                        Console.WriteLine("You've added a pet to the Shelter");                        
                        break;

                    case "2":
                       Console.WriteLine("Give pet name");
                       string Name = Console.ReadLine();
                       virtualPet.GetName(Name);

                        break;

                    case "3":
                        Console.WriteLine("Give pet species");
                        string Species = Console.ReadLine();
                        virtualPet.GetSpecies(Species);
                        break;

                    case "4":
                        Console.WriteLine("View Pet Info");
                        Console.WriteLine("Your pet's name is " + virtualPet.Name + " and it's species is " + virtualPet.Species + ".");
                        break;

                    case "5":
                        Console.WriteLine("View Pet Status");
                        virtualPet.CheckStatus();
                        break;

                    case "6":
                        Console.WriteLine("Feed Pet");
                        virtualPet.FeedPet();
                        break;

                    case "7":
                        Console.WriteLine("Play with Pet");
                        virtualPet.PlayPet();
                        break;

                    case "8":
                        Console.WriteLine("Take Pet to Doctor");
                        virtualPet.DoctorPet();
                        break;

                    case "9":
                        inMenu = false;
                        Console.WriteLine("See yah!");
                        break;
                }
                               
            }

            while (inMenu);
        }    
    }
}
            


         
           
        
    


