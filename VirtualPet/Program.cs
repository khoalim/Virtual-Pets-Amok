using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pets Place!");          

            Console.WriteLine("Type Play or Exit Game");                   
            
            string playOptions = Console.ReadLine().ToLower();

            if (playOptions == "play")
            {
                Console.WriteLine("Menu Options are:");
                
            }

            else
            {
                Environment.Exit(0);

            }

            Console.WriteLine("1. Add Pet to Shelter");
            Console.WriteLine("2. Exit Game");
            string addPet = Console.ReadLine().ToLower();
            VirtualPet virtualPet = new VirtualPet();

            if (addPet == "add pet to shelter")
            {
                Console.WriteLine("What would you like to name your pet?");
                
                virtualPet.Name = Console.ReadLine();
            }

            else
            {
                Environment.Exit(0);
            }

            
            string petName = Console.ReadLine();
            int hungerLevel = 50;
            int boredomLevel = 50;
            int healthLevel = 50;
            int feedPet = (hungerLevel - 20);
            int boredomDecrease = (boredomLevel - 20); 
            
            Console.WriteLine("What species would you like?");
            string petSpecies = Console.ReadLine();

            Console.WriteLine("1. View Pet Info");
            Console.WriteLine("2. View Pet Status");
            Console.WriteLine("3. Feed Pet");
            Console.WriteLine("4. Play with Pet");
            Console.WriteLine("5. Take Pet to Doctor");
            Console.WriteLine("6. Exit Game");
            string petMenuChoice = Console.ReadLine().ToLower();

            switch (petMenuChoice)
            {
                case "view pet info": Console.WriteLine("Your pet's name is " + virtualPet.Name + " and its species is " + petSpecies);
                    break;

                case "view pet status": Console.WriteLine("Your pet's hunger level is " + hungerLevel + "," + " its boredome level is " + boredomLevel + "," + " and its health level is " + healthLevel + ".");
                    break;

                case "feed pet": Console.WriteLine(petName + "'s" + " hunger level decreased to " + feedPet + " after being fed."); 
                    break;

                case "play with pet": Console.WriteLine();
                    break;

                case " take pet to doctor": Console.WriteLine();
                    break;

            }



           
        }
    }
}
