using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class RoboticPets : VirtualPet
    {
        public int Oil { get; set; }
        public int Performance { get; set; }

        public RoboticPets() : base()
        {
            Oil = 100;
            Performance = 5000;
            Type = "robotic";
        }

        public override void PlayPet() 
        {

            Boredom--;
            Performance++;
            Oil--;
            
        }

        public override void MaintainPet()
        {

            Performance++;
        }

        public override void FeedPet()
        {
            Oil++;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Hi! My name is " + Name + " and I'm a/an " + Type + " " + Species + ".");
        }

        public override void CheckStatus()
        {
            Console.WriteLine(Name + "'s stats are: " + " oil " + Oil + "," + " boredom " + Boredom + "," + " performance " + Performance);
        }

    }
}
