using ConsoleRPG.Inventory;
using System.Text;
using System;
using ConsoleRPG.Items;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleRPG.Hero
{
	public abstract class Hero
{
		// Constructor
		protected Hero(string name) => Name = name;

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
		public string EquipItem(Item item, string slot)
		{
			// Determine if item is weapon or armor
			bool isWeapon = item.GetType() == typeof(WeaponItem);
			bool isArmor = item.GetType() == typeof(ArmorItem);

			// Throws error if weapons item level is too high
			if (isWeapon && item.ItemLevel > Level)
				throw new InvalidWeaponException("Weapon level too high!");
			// Throws error if weapons type is not allowed to be equipped
			if (isWeapon && !AllowedWeaponTypes.Contains(item.ItemType))
				throw new InvalidWeaponException("Weapon type not allowed to be equipped!");
			// Throws error if weapon is equipped in an armor slot
			if (isWeapon && slot != Slots.SLOT_WEAPON)
				throw new InvalidWeaponException("Cannot equip weapon in an armor slot!");

			// Throws error if armors item level is too high
			if (isArmor && item.ItemLevel > Level)
				throw new InvalidArmorException("Armor level too high!");
			// Throws error if armors type is not allowed to be equipped
			if (isArmor && !AllowedArmorTypes.Contains(item.ItemType))
				throw new InvalidArmorException("Armor type not allowed to be equipped!");
			// Throws error if armor is equipped in a weapon slot
			if (isArmor && slot == Slots.SLOT_WEAPON)
				throw new InvalidWeaponException("Cannot equip armor in a weapon slot!");

			// If all checks pass, equip the item
			HeroEquipment.EquipmentSlots[slot] = item;

			// Return appropiate success string for item type
			if (isWeapon) return "New weapon equipped!";
			return "New armor equipped!";
		}

		public int LevelUp()
		{
			Level++;
			BasePrimaryAttributes += BasePrimaryAttributesGain;

			return Level;
		}

		private PrimaryAttributes CalculateTotalPrimaryAttributes()
		{
			PrimaryAttributes attributesFromItems = new PrimaryAttributes();
			
			List<string> SlotTypes = HeroEquipment.SlotTypes;
			SlotTypes.Remove("Weapon");

			for (int i = 0; i < SlotTypes.Count; i++)
			{
				ArmorItem currentItem = (ArmorItem)HeroEquipment.EquipmentSlots[SlotTypes[i]];

				if (!(currentItem is null) && (currentItem.GetType() == typeof(ArmorItem)))
					attributesFromItems += currentItem.Attributes;
			}
			
			return BasePrimaryAttributes + attributesFromItems;
		}

		public void DisplayHeroStats()
		{  
			StringBuilder heroStats = new StringBuilder();

			heroStats.AppendLine("Character name: " + Name);
			heroStats.AppendLine("Character level: " + Level);
			heroStats.AppendLine("Strength: " + TotalPrimaryAttributes.Strength);
			heroStats.AppendLine("Dexterity: " + TotalPrimaryAttributes.Dexterity);
			heroStats.AppendLine("Intelligence: " + TotalPrimaryAttributes.Intelligence);
			heroStats.AppendLine("Damage: " + Damage);

			Console.WriteLine(heroStats.ToString());
		}
		
		public abstract double CalculateDamage();
	}
}
