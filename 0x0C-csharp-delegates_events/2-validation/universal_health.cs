using System;

/// <summary>
/// Player: class
/// </summary>
public class Player
{
	/// <summary>
	/// name: property
	/// </summary>
	private string name;

	/// <summary>
	/// maxHp: property
	/// </summary>
	private float maxHp;

	/// <summary>
	/// hp: property
	/// </summary>
	private float hp;


	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="name">string</param>
	/// <param name="maxHp">float</param>
	public Player(string name = "Player", float maxHp = 100f)
	{
		this.name = name;
		if (maxHp <= 0)
		{
			this.maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		else
			this.maxHp = maxHp;
		hp = this.maxHp;
	}

	/// <summary>
	/// PrintHealth: method that prints player's current health status
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}

	/// <summary>
	/// CalculateHealth: delegate
	/// </summary>
	/// <param name="amount">float</param>
	public delegate void CalculateHealth(float amount);

	/// <summary>
	/// ValidateHP: method
	/// </summary>
	/// <param name="newHp"></param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			newHp = 0f;
		if (newHp > maxHp)
			newHp = maxHp;
		hp = newHp;
	}

	/// <summary>
	/// TakeDamage: method
	/// </summary>
	/// <param name="damage">float</param>
	public void TakeDamage(float damage)
	{
		float newHpValue = hp;
		
		if (damage < 0)
		{
			damage = 0f;
			Console.WriteLine($"{name} takes 0 damage!");
		}
		else
		{
			Console.WriteLine($"{name} takes {damage} damage!");
			newHpValue -= damage;
		}
		ValidateHP(newHpValue);
	}

	/// <summary>
	/// HealDamage: method
	/// </summary>
	/// <param name="heal">float</param>
	public void HealDamage(float heal)
	{
		float newHpValue = hp;
		
		if (heal < 0)
		{
			heal = 0f;
			Console.WriteLine($"{name} heals 0 HP!");
		}
		else
		{
			Console.WriteLine($"{name} heals {heal} HP!");
			newHpValue += heal;
		}
		ValidateHP(newHpValue);
	}
}
