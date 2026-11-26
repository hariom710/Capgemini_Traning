using System;

namespace GameCharacterSystem
{
    internal class Mage : GameCharacter, ISpecialAbility
    {
        public override void Attack(GameCharacter enemy)
        {
            int dmg = 20 + Level;
            enemy.Health -= dmg;
            Console.WriteLine($"{Name} casts Fireball for {dmg} damage");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine($"{Name} uses Mana Burst!");
        }
    }
}