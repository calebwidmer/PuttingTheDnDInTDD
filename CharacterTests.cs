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


        [Fact]
        public void CharacterCanRoll()
        {
            Character character = new Character();

            Assert.True(character.Roll()>0);
         


        }
        [Fact]
        public void CharacterCanHit()
        {
            Character protagonist = new Character();
            Character antagonist = new Character();
            antagonist.ArmorClass = 14;


            
            Assert.True(protagonist.CanHit(antagonist));



        }
    }
}
