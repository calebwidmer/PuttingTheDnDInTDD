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

        [Fact]
        public void SetAlignment()
        {
            
            Character character = new Character();

            character.SetAlignment(Alignment.Good);

            Assert.Equal("Good", character.Alignment.ToString());
        }

        [Fact] 
        public void ArmorClassSetTo10()
        {
            Character character = new Character();

            Assert.Equal(10, character.ArmorClass);
        }



        [Fact]
        public void CharacterHitPointsSetTo5()
        {
            Character character = new Character();

            Assert.Equal(5, character.HitPoints);
        }
    }
}
