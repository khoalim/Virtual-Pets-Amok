using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class OrganicPets : VirtualPet

    {
        public OrganicPets() :base()
        {

            Hunger = 100;
            Health = 100;
            Type = "organic";
        }


        //public override void AddPet(string name, string species)
        //{
        //    base.AddPet(name, species);
        //    Name = name;
        //    Species = species;

        //}


        public override void GetInfo()
        {
            Console.WriteLine("Hi! My name is " + Name + " and I'm a/an " + Type + " " + Species + ".");
        }

        public override void CheckStatus()
        {
            Console.WriteLine(Name + "'s stats are: " + " hunger " + Hunger + "," + " boredom " + Boredom + "," + " health " + Health);
        }
    }
}
