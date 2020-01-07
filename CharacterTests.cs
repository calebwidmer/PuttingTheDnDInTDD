using PuttingTheDnDInTDDLib;
using System;
using Xunit;

namespace TestPuttingTheDnDInTDD
{
    public class CharacterTests
    {
        [Fact]
        public void CharacterSetsName()
        {
            Character character = new Character();

            character.SetName("Aragon");

            Assert.Equal("Aragon", character.Name);
        }
    }
}
