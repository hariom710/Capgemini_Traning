using System;

namespace GameCharacterSystem
{
    internal abstract class GameCharacter
    {
        public string Name { get; set; } = "";
        public int Health { get; set; }
        public int Level { get; set; }

        public abstract void Attack(GameCharacter enemy);

        public virtual void ShowStatus()
        {
            Console.WriteLine($"{Name} | HP: {Health} | Level: {Level}");
        }
    }
}