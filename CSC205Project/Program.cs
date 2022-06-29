using System;
namespace CSC205Project
{
	public class Program
	{
		public static void Main(string[] args)
        {
            Player tigger = new Player();
            tigger.name = "Tigger";
			tigger.DisplayStats(tigger);

			Enemy.Wolf wolf = new Enemy.Wolf();
			Enemy.Bear bear = new Enemy.Bear();




			tigger.TakeDamage(tigger, wolf);
			tigger.DisplayStats(tigger);
			tigger.TakeDamage(tigger, bear);
			tigger.DisplayStats(tigger);
			
		}
	}
}