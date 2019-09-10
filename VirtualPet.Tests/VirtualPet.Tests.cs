using System;
using Xunit;

namespace VirtualPet.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Can_Create_VirtualPet()
        {
            new VirtualPet();
        }

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
            virtualPet.Species = "real";

            //Assert
            Assert.Equal("real", virtualPet.Species);

        }

        [Fact]

        public void Pet_Has_Hunger()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Hunger = 42;

            //Assert
            Assert.Equal(42, virtualPet.Hunger);

        }

        [Fact]

        public void Pet_Has_Boredom()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Boredom = 42;

            //Assert
            Assert.Equal(42, virtualPet.Boredom);

        }

        [Fact]

        public void Pet_Has_Health()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Health = 42;

            //Assert
            Assert.Equal(42, virtualPet.Health);

        }

        [Fact]

        public void Can_Feed_Pet()
        {
            // Arrange
            VirtualPet virtualPet = new VirtualPet();

            //Act
            virtualPet.Hunger = 42;
            virtualPet.Feed = ();
            

            //Assert
            Assert.Equal(42, virtualPet.Feed);










        }
    }
