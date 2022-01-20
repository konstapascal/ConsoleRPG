using ConsoleRPG.Attributes;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System.Collections.Generic;

namespace ConsoleRPG.Hero.HeroClasses
{
	public class WarriorHero : Hero
	{
		// Constructor
		public WarriorHero(string name) : base(name)
		{
			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 5, Dexterity = 2, Intelligence = 1 };
			BasePrimaryAttributesGain = new PrimaryAttributes() { Strength = 3, Dexterity = 2, Intelligence = 1 };

			AllowedArmorTypes = new List<string> { ArmorType.ARMOR_MAIL, ArmorType.ARMOR_PLATE };
			AllowedWeaponTypes = new List<string> { WeaponType.WEAPON_AXE, WeaponType.WEAPON_HAMMER, WeaponType.WEAPON_SWORD };
		}

		// Methods
		public override double CalculateDamage()
		{
			WeaponItem equippedWeapon = (WeaponItem) HeroEquipment.EquipmentSlots[Slots.SLOT_WEAPON];

			double damagePerSecond = (equippedWeapon is null) ? 1 : equippedWeapon.DamagePerSecond;
			double calculatedDamage = damagePerSecond * (1 + (double) TotalPrimaryAttributes.Strength / 100);

			return calculatedDamage;
		}
	}
}
