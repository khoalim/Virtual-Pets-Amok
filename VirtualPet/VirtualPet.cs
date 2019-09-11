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

        public VirtualPet()
        {
            
            Hunger = 100;
            Boredom = 100;
            Health = 100;
            
        }                   
        

        public void GetName(string Name)
        {
            this.Name = Name;
            Console.WriteLine();
        }

        public void GetSpecies(string Species)
        {
            this.Species = Species;
            Console.WriteLine();
        }

        public void CheckStatus()
        {
            Console.WriteLine("Your pet's stats are: " + "hunger " + Hunger + "," + " boredom " + Boredom + "," + " health " + Health);
        }

        public int FeedPet()
        {
            Hunger--;
            return Hunger;
        }
        
        public int DoctorPet()
        {
            
            Health++;
            return Health;           
        }

        public int PlayPet()
        {
            Hunger++;
            Boredom--;
            Health++;

            return Hunger + Boredom + Health;
        }
           


      
         




    }
}


