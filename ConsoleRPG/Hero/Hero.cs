using ConsoleRPG.Inventory;
using System.Text;
using System;
using ConsoleRPG.Items;
using System.Collections.Generic;
using ConsoleRPG.Exceptions;
using ConsoleRPG.Attributes;
using ConsoleRPG.Exceptions.CustomExceptions;

namespace ConsoleRPG.Hero
{
	public abstract class Hero
{
		// Constructor
		public Hero(string name) => Name = name;

		// Properties
		public string Name { get; init; }
		public int Level { get; protected set; } = 1;
		public PrimaryAttributes BasePrimaryAttributes { get; set; }
		public PrimaryAttributes BasePrimaryAttributesGain { get; init; }
		public PrimaryAttributes TotalPrimaryAttributes { get { return CalculateTotalPrimaryAttributes(); } }
		public Equipment HeroEquipment { get; init; } = new Equipment();
		public List<string> AllowedWeaponTypes { get; init; }
		public List<string> AllowedArmorTypes { get; init; }
		public double Damage { get { return CalculateDamage(); } }

		// Methods

		/// <summary>
		/// Equips provided item to the current character
		/// </summary>
		/// <param name="item">Item to be equipped</param>
		/// <param name="slot">Slot in which to equip item</param>
		/// <returns>Returns a success message</returns>
		/// <exception cref="InvalidWeaponException">When weapon level is too high, weapon type is not allowed or slot is wrong</exception>
		/// <exception cref="InvalidArmorException">When armor level is too high, armor type is not allowed or slot is wrong</exception>
		public string EquipItem(Item item, string slot)
		{
			// Determine if item is weapon or armor
			bool isWeapon = item.GetType() == typeof(WeaponItem);
			bool isArmor = item.GetType() == typeof(ArmorItem);

			// Throw any exception that could come up
			CustomExceptionThrower.WeaponExceptionThrower(item, slot, isWeapon, Level, AllowedWeaponTypes);
			CustomExceptionThrower.ArmorExceptionThrower(item, slot, isArmor, Level, AllowedArmorTypes);

			// If all checks pass, equip the item
			HeroEquipment.EquipmentSlots[slot] = item;

			// Return appropiate success string for item type
			if (isWeapon) return "New weapon equipped!";
			return "New armor equipped!";
		}

		/// <summary>
		/// Levels up the current character by 1 and adds attributes
		/// </summary>
		/// <returns>Returns the new level</returns>
		public int LevelUp()
		{
			// Increment level and increase attributes by the gain
			Level++;
			BasePrimaryAttributes += BasePrimaryAttributesGain;

			return Level;
		}

		/// <summary>
		/// Calculates the total primary attributes from both levels and items
		/// </summary>
		/// <returns>Returns total attributes</returns>
		private PrimaryAttributes CalculateTotalPrimaryAttributes()
		{
			PrimaryAttributes attributesFromItems = new PrimaryAttributes();
			
			// Get all slots but the weapon
			List<string> SlotTypes = HeroEquipment.SlotTypes;
			SlotTypes.Remove("Weapon");

			// Increment all slots
			for (int i = 0; i < SlotTypes.Count; i++)
			{
				// Cast the current Item to ArmorItem
				ArmorItem currentItem = (ArmorItem) HeroEquipment.EquipmentSlots[SlotTypes[i]];

				// If an ArmorItem is equipped, add its attributes
				if (!(currentItem is null))
					attributesFromItems += currentItem.Attributes;
			}
			
			// Return total attributes from character and items
			return BasePrimaryAttributes + attributesFromItems;
		}

		/// <summary>
		/// Displays the current characters name, level, attributes and damage
		/// </summary>
		public void DisplayHeroStats()
		{  
			StringBuilder heroStats = new StringBuilder();

			// Build the string with all the stats
			heroStats.AppendLine("Character name: " + Name);
			heroStats.AppendLine("Character level: " + Level);
			heroStats.AppendLine("Strength: " + TotalPrimaryAttributes.Strength);
			heroStats.AppendLine("Dexterity: " + TotalPrimaryAttributes.Dexterity);
			heroStats.AppendLine("Intelligence: " + TotalPrimaryAttributes.Intelligence);
			heroStats.AppendLine("Damage: " + Damage);

			Console.WriteLine(heroStats.ToString());
		}
		
		/// <summary>
		/// Calculate the characters damage based on his weapon and attributes
		/// </summary>
		/// <returns>Returns the calculated damage</returns>
		public abstract double CalculateDamage();
	}
}
