using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class VirtualPet
    {
        // These are the properties
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public int Health { get; set; }

        // These are constructors
        public VirtualPet()
        {
            
            Hunger = 100;
            Boredom = 100;
            Health = 100;
            
        }

        Dictionary<string, string> shelterPets = new Dictionary<string, string>();

        // These are the methods

        public void GetName(string name)
        {
            this.Name = name;
            Console.WriteLine();
        }

        public void GetSpecies(string species)
        {
            this.Species = species;
            Console.WriteLine();
        }

        public void CheckStatus()
        {
            Console.WriteLine("Your pet's stats are: " + "hunger " + Hunger + "," + " boredom " + Boredom + "," + " health " + Health);
        }

        public void GetInfo()
        {
            Console.WriteLine("Your pet's name is " + Name + " and it's species is " + Species + ".");
        }

        public void FeedPet()
        {
            Hunger--;
            //return Hunger;           
        }
        
        public void DoctorPet()
        {
            
            Health++;
            //return Health;           
        }

        public void PlayPet()
        {
            Hunger++;
            Boredom--;
            Health++;
            // return Hunger + Boredom + Health;
        }  

         public void DictionaryList()
        {
            shelterPets.Add(Name, Species);
            Console.WriteLine("The pets in your shelter are: " + Name + " the " + Species);
        }      
    }
}


