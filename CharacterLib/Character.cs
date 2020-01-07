using System;

namespace CharacterLib
{

    public enum Alignment { Evil, Good, Neutral }
    public class Character
    {
        public string Name { get; set; }
        public Alignment Alignment { get; set; }

        public int ArmorClass { get; set; } = 10;
        public int HitPoints { get; set; } = 5;

        public int Damage { get; set; } = 1;
        public void SetName(string name)
        {
            Name = name;
        }

        public void SetAlignment(Alignment alignment)
        {
            Alignment = alignment;
        }

        public int Roll(int fakeRoll)
        {
            return fakeRoll;
        }

        public bool CanHit(Character antagonist, int roll)
        {
            return roll >= antagonist.ArmorClass;
        }

        public void Wound(Character antagonist, int damage)
        {
            antagonist.HitPoints -= damage;
        }
        public void PlayerTurn(Character antagonist, int fakeRole)
        {


            if (CanHit(antagonist, fakeRole))
            {
                Wound(antagonist, 1);
            }

            if (fakeRole == 20)
            {
                Wound(antagonist, 1);
            }

        }
    }
}
