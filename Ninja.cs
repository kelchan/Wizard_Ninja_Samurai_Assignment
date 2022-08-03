namespace human;

public class Ninja : Human
{
    public Ninja( string name ) : base( name )
    {
        Dexterity = 175;
    }
    // Add a constructor to assign custom values to all fields
    public Ninja( string name, int strength, int intelligence, int dexterity, int health ) : base( name, strength, intelligence, dexterity, health) 
    {}

    // Build Attack method
    public override int Attack( Human target )
    {
        int damage = Dexterity * 5;
        target.Health -= damage;
        Random random = new Random();
        int randomNum = random.Next( 1, 6 );
        if( randomNum == 1 )
        {
            target.Health -= 10;
        }
        return target.Health;
    }

    public string Steal( Human target )
    {
        target.Health -= 5;
        Health += 5;
        return $"{ Name } stole 5 health from { target.Name }, { Name }'s health increased by 5, { target.Name } remaining health: { target.Health }";
    }

}