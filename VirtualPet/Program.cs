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
                string petName = Console.ReadLine();

                Console.WriteLine("What species would you like?");
                string petSpecies = Console.ReadLine();
            }

            else
            {
                Environment.Exit(0);
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
