using ConsoleRPG.Inventory;
using System.Text;
using System;
using ConsoleRPG.Items;
using System.Collections.Generic;

namespace ConsoleRPG.Hero
{
	public abstract class Hero
	{
		// Constructor
		protected Hero(string name)
		{
			Name=name;
		}

		// Properties
		public string Name { get; init; }
		public int Level { get; protected set; } = 1;
		public PrimaryAttributes BasePrimaryAttributes { get; init; }
		public PrimaryAttributes BasePrimaryAttributesGain { get; init; }
		public PrimaryAttributes TotalPrimaryAttributes { get; set; }
		public Equipment HeroEquipment { get; init; } = new Equipment();
		public List<string> AllowedWeaponTypes { get; init; }
		public List<string> AllowedArmorTypes { get; init; }

		// Methods
		public string EquipItem(Item item, string slot)
		{
			// Determine if item is weapon or armor
			bool isWeapon = item.GetType() == typeof(WeaponItem);
			bool isArmor = item.GetType() == typeof(ArmorItem);

			// Throws error if weapons item level is too high
			if (item.ItemLevel > Level && isWeapon) 
				throw new InvalidWeaponException("Item level to high!");

			// Throws error if weapons type is not allowed to be equipped
			if (!AllowedWeaponTypes.Contains(item.ItemType) && isWeapon)
				throw new InvalidWeaponException("Weapon type not allowed to be equipped!");

			// Throws error if armors item level is too high
			if (item.ItemLevel > Level && isArmor)
				throw new InvalidArmorException();

			// Throws error if armors type is not allowed to be equipped
			if (!AllowedArmorTypes.Contains(item.ItemType) && isArmor)
				throw new InvalidArmorException();

			return "New armor equipped!";
		}

		public int RemoveItem(Item item)
		{
			throw new NotImplementedException();
		}
		public int LevelUp()
		{
			Level++;
			TotalPrimaryAttributes += BasePrimaryAttributesGain;

			return Level;
		}
		public void DisplayHeroStats()
		{
			StringBuilder heroStats = new StringBuilder();

			heroStats.AppendLine("Character name: " + Name);
			heroStats.AppendLine("Character level: " + Level);
			heroStats.AppendLine("Strength: " + TotalPrimaryAttributes.Strength);
			heroStats.AppendLine("Strength: " + TotalPrimaryAttributes.Dexterity);
			heroStats.AppendLine("Strength: " + TotalPrimaryAttributes.Intelligence);
			heroStats.AppendLine("Damage: ");

			Console.WriteLine(heroStats.ToString());
		}
		public abstract int DealDamage();
	}
}
