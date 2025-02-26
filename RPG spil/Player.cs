using System;

namespace RPG_spil
{

	internal class Player : Character
	{
		//Fields
		private int _level;
		private int _xp;
		private List<string> _inventory;

		//Constructor
		public Player(string name, int health, int attackDamage, int defence)
			: base (name, health, attackDamage, defence)
		{
			_level = 1;
			_xp = 0;
			_inventory = new List<string>();

		}


		//Methods
		public void GainXP(int amount)
		{
			_xp += amount;
			Console.WriteLine($"{_name} has gained {amount} XP! Total XP: {_xp}");

			if (_xp >= _level * 10)
			{
				LevelUp();
			}

		}

		private void LevelUp()
		{
			_level++;
			_xp = 0;
			_health += 10;
			_attackDamage += 2;
			_defence += 1;

			Console.WriteLine($"{_name} leveled up to level {_level}!");
			Console.WriteLine($"New stats--> Health: {_health}, Attack: {_attackDamage}, Defence: {_defence}");
		}

		public void AddItem(string item)
			{ 
				_inventory.Add( item );
				Console.WriteLine($"{_name} picked up {item}");
			}

		public void ShowInventory()
		{
			Console.WriteLine($"{_name}'s inventory:");
			if (_inventory.Count == 0)
			{
				Console.WriteLine($"Your inventory is empty");
			}

			else
			{
				foreach (string item in _inventory)
				{
					Console.WriteLine($"{item}");
				}
			}
		}
	}
}
	
  
 