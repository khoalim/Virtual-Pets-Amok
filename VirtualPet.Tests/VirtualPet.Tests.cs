using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class UnitTest1
    {
       
        [Fact]
        public void Pet_Has_Name()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Name = "Buddy";

            //Assert
            Assert.Equal("Buddy", virtualPet.Name);
        
        }

        [Fact]
        public void Pet_Has_Species()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Species = "dog";

            //Assert
            Assert.Equal("dog", virtualPet.Species);

        }

        [Fact]
        public void Pet_Has_HungerLevel()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Hunger = 100;

            //Assert
            Assert.Equal(100, virtualPet.Hunger);

        }

        [Fact]
        public void Pet_Has_BoredomLevel()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Boredom = 100;

            //Assert
            Assert.Equal(100, virtualPet.Boredom);

        }

        [Fact]
        public void Pet_Has_HealthLevel()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Health = 100;

            //Assert
            Assert.Equal(100, virtualPet.Health);

        }

        [Fact]
        public void Should_Feed_Pets_And_Decrease_HungerLevel_By_One()
        {
            //Arrange
            VirtualPet virtualPet = new VirtualPet();
            virtualPet.Hunger = 100;

            //Act
            virtualPet.FeedPet();

            //Assert
            Assert.Equal(99, virtualPet.Hunger);
        }

        [Fact]
        public void Should_Doctor_Pets_And_Increase_HealthLevel_By_One()
        {
            //Arrange
            VirtualPet virtualPet = new VirtualPet();
            virtualPet.Health = 100;

            //Act
            virtualPet.DoctorPet();

            //Assert
            Assert.Equal(101, virtualPet.Health);
        }

        [Fact]
        public void Should_Feed_All_Pets_And_Decrease_Hunger_By_One()
        {
            //Arrange
            VirtualPet virtualPet = new VirtualPet();
            virtualPet.Health = 100;


            //Act


            //Assert

        }



    }
    }
