using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<VirtualPet> ShelterPets = new List<VirtualPet>();
  
        

        public void AddPets (string name, string species)
        {
            VirtualPet virtualPet = new VirtualPet (name, species);
            ShelterPets.Add(virtualPet);
        }

    }
}
