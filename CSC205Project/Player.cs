using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Project
{


	public class Player
	{
		public string name { get; set; }
		public int maxhealth;
		public int health;
		public int armor;
		public int attack;
		int[] inventory = new int[10];
		int[] allitems = new int[10];
		public Player() // Base Constructor
		{
			name = "";
			health = 5;
			maxhealth = 5;
			armor = 0;
			attack = 1;

		}
		public Player(string name, int health, int maxhealth, int armor, int attack) // Parametric Constructor
		{
			this.name = name;
			this.health = 5;
			this.maxhealth = 5;
			this.armor = 0;
			this.attack = 1;
		}

		public int TakeDamage(Player player, Enemy enemy)
		{
			player.health = player.health - (enemy.attack - player.armor);
			return player.health;
		}
		public static int DealDamage(Player player, Enemy enemy)
		{
			enemy.health = enemy.health - player.attack;
			return enemy.health;
		}
		public void DisplayInventory(Player player)
		{
			Console.WriteLine("Inventory : ");
			foreach (var item in inventory)
				Console.WriteLine(player.inventory);
		}	
			
			
  //      public int HealPlayerB(Player player, Item.Bandage bandage)
  //      {
		//	if (health < maxhealth)
		//	{
		//		player.health = player.health + bandage.heal;
		//	}
		//		return player.health;
  //      }
		//public int HealPlayerM(Player player, Item.Medkit medkit)
		//{
		//	if (health < maxhealth)
		//	{
		//		player.health = player.health + medkit.heal;
		//		return player.health;
		//	}
		//	if (health > maxhealth)
		//	{
		//		return maxhealth;
		//	}
		//	return player.health;
			

		//}
		public void DisplayStats(Player player)
		{
			global::System.Console.WriteLine($"Character Name : {player.name} \n MaxHealth : {maxhealth}  \n Health : {health} \n Armor : {armor} \n Attack : {attack} ");
		}




	}
}
