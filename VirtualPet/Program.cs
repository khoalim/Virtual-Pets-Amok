using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Virtual Pets Place!");          

            Console.WriteLine("Play or Exit Game");                   
            
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
            

            if (addPet == "add pet to shelter")
            {
                Console.WriteLine("What would you like to name your pet?");
            }

            else
            {
                Environment.Exit(0);
            }

            
            string petName = Console.ReadLine();
            int hungerLevel;
            int boredomLevel;
            int healthLevel;

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
                case "view pet info": Console.WriteLine("Your pet's name is " + petName + " and its species is " + petSpecies);
                    break;

                case "view pet status": Console.WriteLine("Your pet's hunger level is " + hungerLevel + "," + "its boredome level is " + boredomLevel + "," + "and its health level is " + healthLevel + ".");
                    break;
                case "feed pet": Console.WriteLine();
                    break;
            }





            /*do
            {
                //if (playOptions == "play")
                {
                    //Console.WriteLine("play");
                    
                    //break;
                }

                //else if (playOptions == "exit")
                {
                    Console.WriteLine("Goodbye! Hit any key to exit");
                    Console.ReadKey();
                    //break;
                }
            }*/

            // while (playOptions != "play" || playOptions != "exit");


        }
    }
}
