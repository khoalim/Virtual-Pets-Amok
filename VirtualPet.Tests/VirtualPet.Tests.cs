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
        public void Pet_Has_Hunger()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Hunger = 100;

            //Assert
            Assert.Equal(100, virtualPet.Hunger);

        }

        [Fact]
        public void Pet_Has_Boredom()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Boredom = 100;

            //Assert
            Assert.Equal(100, virtualPet.Boredom);

        }

        [Fact]
        public void Pet_Has_Health()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Health = 100;

            //Assert
            Assert.Equal(100, virtualPet.Health);

        }

        [Fact]
        public void Pet_Can_Feed()
        {
            //Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.FeedPet();

            //Assert
            Assert.Equal(99, virtualPet.Hunger);
        }

        [Fact]
        public void Pet_Can_Doctor()
        {
            //Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.DoctorPet();

            //Assert
            Assert.Equal(101, virtualPet.Health);
        }



    }
    }
