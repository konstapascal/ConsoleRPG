﻿using ConsoleRPG.Attributes;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System.Collections.Generic;

namespace ConsoleRPG.Hero.HeroClasses
{
	public class RangerHero : Hero
	{
		// Constructor
		public RangerHero(string name) : base(name)
		{
			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 7, Intelligence = 1 };
			BasePrimaryAttributesGain = new PrimaryAttributes() { Strength = 1, Dexterity = 5, Intelligence = 1 };

			AllowedWeaponTypes = new List<string> { WeaponType.WEAPON_BOW };
			AllowedArmorTypes = new List<string> { ArmorType.ARMOR_LEATHER, ArmorType.ARMOR_MAIL };
		}

		// Methods
		public override double CalculateDamage()
		{
			WeaponItem equippedWeapon = (WeaponItem)HeroEquipment.EquipmentSlots[Slots.SLOT_WEAPON];

			// Calculate damage per second of weapon, 1 if nothing equipped
			double damagePerSecond = (equippedWeapon is null) ? 1 : equippedWeapon.DamagePerSecond;
			double calculatedDamage = damagePerSecond * (1 + (double) TotalPrimaryAttributes.Dexterity / 100);

			return calculatedDamage;
		}
	}
}
