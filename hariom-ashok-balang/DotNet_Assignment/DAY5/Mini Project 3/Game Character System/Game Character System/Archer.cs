using GameCharacterSystem;
using System;

namespace GameCharacterSystem
{
    internal class Archer : GameCharacter, ISpecialAbility
    {
        public override void Attack(GameCharacter enemy)
        {
            int dmg = 12 + Level;
            enemy.Health -= dmg;
            Console.WriteLine($"{Name} shoots arrow for {dmg} damage");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine($"{Name} uses Rapid Shot!");
        }
    }
}