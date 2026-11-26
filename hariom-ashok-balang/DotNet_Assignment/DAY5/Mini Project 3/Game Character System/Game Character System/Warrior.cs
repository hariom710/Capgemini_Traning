using GameCharacterSystem;
using System;

namespace GameCharacterSystem
{
    internal class Warrior : GameCharacter, ISpecialAbility
    {
        public override void Attack(GameCharacter enemy)
        {
            int dmg = 15 + Level;
            enemy.Health -= dmg;
            Console.WriteLine($"{Name} slashes enemy for {dmg} damage");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine($"{Name} uses Rage Mode!");
        }
    }
}