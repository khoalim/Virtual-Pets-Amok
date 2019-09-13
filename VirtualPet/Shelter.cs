using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<VirtualPet> ShelterPets = new List<VirtualPet>();



        public void AddPetToShelter(VirtualPet virtualPet)
        {
           
            ShelterPets.Add(virtualPet);
        }

    }
}
