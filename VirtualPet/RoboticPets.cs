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
        }
    }
}
