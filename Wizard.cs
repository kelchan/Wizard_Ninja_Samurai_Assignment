namespace human;

public class Wizard : Human
{
    public Wizard( string name ) : base( name )
    {
        Health = 50;
        Intelligence = 25;
    }

    public override int Attack(Human target)
    {
        target.Health -= 5 * Intelligence;
        Health += 5 * Intelligence;
        return target.Health;
    }

    public string Heal( Human target )
    {
        int healAmount = 10 * Intelligence;
        target.Health += healAmount;
        return $"{ Name } healed { target.Name } for { healAmount } health";
    }

}