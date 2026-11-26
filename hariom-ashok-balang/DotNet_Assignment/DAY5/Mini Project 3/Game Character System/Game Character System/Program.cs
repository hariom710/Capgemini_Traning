using GameCharacterSystem;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace GameCharacterSystem
{
    internal class Program
    {
        static GameCharacter player = null!;
        static GameCharacter enemy = new Warrior
        {
            Name = "Enemy",
            Health = 100,
            Level = 1
        };

        static void Main(string[] args)
        {
            int ch;

            do
            {
                Console.WriteLine("\n--- Game Menu ---");
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. Attack Enemy");
                Console.WriteLine("3. Show Status");
                Console.WriteLine("4. Use Special Ability");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1: CreateCharacter(); break;
                    case 2: DoAttack(); break;
                    case 3: ShowAllStatus(); break;
                    case 4: UseAbility(); break;
                }

            } while (ch != 0);
        }

        static void CreateCharacter()
        {
            Console.Write("1.Warrior 2.Mage 3.Archer : ");
            int t = Convert.ToInt32(Console.ReadLine());

            if (t == 1) player = new Warrior();
            else if (t == 2) player = new Mage();
            else player = new Archer();

            Console.Write("Enter name: ");
            player.Name = Console.ReadLine() ?? "";

            player.Health = 100;
            player.Level = 1;

            Console.WriteLine("Character created.");
        }

        static void DoAttack()
        {
            if (player == null)
            {
                Console.WriteLine("Create character first.");
                return;
            }

            player.Attack(enemy);

            if (enemy.Health <= 0)
            {
                Console.WriteLine("Enemy defeated!");
                enemy.Health = 100;
                player.Level++;
                Console.WriteLine("Level Up! New Level: " + player.Level);
            }
        }

        static void ShowAllStatus()
        {
            player?.ShowStatus();
            enemy.ShowStatus();
        }

        static void UseAbility()
        {
            if (player is ISpecialAbility sp)
                sp.UseSpecialAbility();
            else
                Console.WriteLine("No special ability.");
        }
    }
}