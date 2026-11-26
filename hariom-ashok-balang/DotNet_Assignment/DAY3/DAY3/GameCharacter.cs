abstract class GameCharacter
{
    public abstract void Attack();
}

class Warrior : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine("Warrior attacks with sword");
    }
}

class Mage : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts spell");
    }
}

class Archer : GameCharacter
{
    public override void Attack()
    {
        Console.WriteLine("Archer shoots arrow");
    }
}