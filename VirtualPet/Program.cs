using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type PLAY to enter game or EXIT to leave");
            string menu = Console.ReadLine().ToLower();

            if (menu == "play")
            {
                Console.WriteLine("Welcome to Virtual Pets Place!");
                // Console.WriteLine("Would you like a real or robotic pet?");
            }

            else if (menu == "exit")
            {
                Console.WriteLine("Goodbye! Hit any key to exit");
                Console.ReadKey();
            }

            


        }
    }
}
