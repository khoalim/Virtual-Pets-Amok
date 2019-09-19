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
        public string Type { get; set; }
        

        


        // These are constructors
        public VirtualPet()
        {

            Boredom = 100;
        }


        // These are the methods

        public void AddPet(string name, string species)
        {
            Name = name;
            Species = species;

        }


        public virtual void CheckStatus()
                    
          {
             Console.WriteLine(Name + "'s stats are: " + " hunger " + Hunger + "," + " boredom " + Boredom + "," + " health " + Health);
          }  
                
                          
        

        public virtual void GetInfo()
        {
            Console.WriteLine("Hi! My name is " + Name + " and I'm a/an " + Type + " " + Species + ".");
        }

        public virtual void FeedPet()
        {
            Hunger--;                     
        }
        
        public virtual void MaintainPet()
        {
           
            Health ++;                     
        }

        public virtual void PlayPet()
        {
            Hunger++;
            Boredom--;
            Health++;
            
            // return Hunger + Boredom + Health;
        }

        

    }


}


