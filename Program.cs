using human;


Human human1 = new Human( "Spensir" );
Human human2 = new Human( "Kelvin" );
Ninja ninja1 = new Ninja( "Aparna" );
Samurai samurai1 = new Samurai( "Alex" );
Wizard wizard1 = new Wizard( "Billy" );


Console.WriteLine( human1.Name );
Console.WriteLine( human1.Attack( human2 ) );
Console.WriteLine( ninja1.Name );
Console.WriteLine( ninja1.Steal( human2 ) );
Console.WriteLine( ninja1.Attack( samurai1 ) );
samurai1.Meditate();
Console.WriteLine( samurai1.Health );
Console.WriteLine( human2.Health );
Console.WriteLine( wizard1.Heal( human2 ) );
Console.WriteLine( human2.Health );









