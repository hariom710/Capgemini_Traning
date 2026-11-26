abstract class GameCharacter
{
    public abstract void Attack();
}

class Warrior : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine("Warrior slashes");
    }
}

class Mage : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts fireball");
    }
}

class Archer : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine("Archer shoots arrow");
    }
}