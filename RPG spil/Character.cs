using System;

public class Character
{
	//Fields
	private string name;
	private int health;
	private int atttackDamage;
	private int defense;

	//Constructor
	public Character(string name, int health, int attackDamage, int defense)
	{
		_name = name;
		_health = health;
		_attackDamage = attackDamage;
		_defence = defense;


	}

	//Methods
	public int Attack()
	{
		return attackDamage;
	}

	public void TakeDamage(int damage)
	{
		int actualDamage = damage - _defense;
		if (actualDamage < 0)
		{
			actualDamage = 0;
		}

		_health -= actualDamage;
		Console.WriteLine($"{_name} takes {actualDamage} damage! Health left: {_health}");

		if (_health <= 0)
		{
			Console.WriteLine($"{_name} has been defeated");
		}
	}
}