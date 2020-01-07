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

            Assert.True(character.Roll(1)>0);
         


        }
        [Fact]
        public void CharacterCanBeat()
        {
            Character protagonist = new Character();
            Character antagonist = new Character();
            //antagonist.ArmorClass = 14;
            Assert.True(protagonist.CanHit(antagonist, antagonist.ArmorClass+1));

        }

        [Fact]
        public void CharacterCanMeet()
        {
            Character protagonist = new Character();
            Character antagonist = new Character();

            Assert.True(protagonist.CanHit(antagonist, antagonist.ArmorClass));

        }

        [Fact]
        public void CharacterCanMiss()
        {
            Character protagonist = new Character();
            Character antagonist = new Character();

            Assert.False(protagonist.CanHit(antagonist, antagonist.ArmorClass - 1));

        }


        //If a roll is a natural 20 then a critical hit is dealt and the damage is doubled
        [Fact]
        public void CharacterCanDamage()
        {
            Character protagonist = new Character();
            Character antagonist = new Character();
            int initialHitPoints = antagonist.HitPoints;

            protagonist.Wound(antagonist, 1);

            Assert.True(initialHitPoints-1 == antagonist.HitPoints );

        }

        [Fact]
        public void CriticalHitDoublesDamage()
        {
            Character protagonist = new Character();
            Character antagonist = new Character();
            int initialHitPoints = antagonist.HitPoints;

            protagonist.PlayerTurn(antagonist, 20);

            Assert.True(initialHitPoints - 2 == antagonist.HitPoints);
        }
    }
}
