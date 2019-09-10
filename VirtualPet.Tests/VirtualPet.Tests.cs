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




    }
}
