namespace human;

public class Samurai : Human 
{
    public Samurai( string name ) : base( name )
    {
        Health = 200;
    }

    public override int Attack(Human target)
    {
        if( target.Health < 50 )
        {
            target.Health = 0;
        }
        return target.Health;
    }

    public void Meditate()
    {
        Health = 200;
    }
}