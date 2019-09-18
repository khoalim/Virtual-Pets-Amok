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

        public void DisplayInfoList()
        {
            foreach (VirtualPet virtualPet in ShelterPets)
            {
                virtualPet.GetInfo();
            }

        }

        public void DisplayStatusList()
        {
            foreach (VirtualPet virtualPet in ShelterPets)
            {
                virtualPet.CheckStatus();
            }

        }

        public void FeedAllPets()
        {
            foreach (VirtualPet virtualPet in ShelterPets)
            {
                virtualPet.FeedPet();
            }

        }

        public void PlayAllPets()
        {
            foreach (VirtualPet virtualPet in ShelterPets)
            {
                virtualPet.PlayPet();
            }

        }

        public void DoctorAllPets()
        {
            foreach (VirtualPet virtualPet in ShelterPets)
            {
                virtualPet.MaintainPet();
            }

        }

        public void RemovePet(VirtualPet petChoice)
        {
            ShelterPets.Remove(petChoice);
        }
        
    }
}

    

