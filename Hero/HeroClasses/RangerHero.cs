using ConsoleRPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			WeaponItem equippedWeapon = (WeaponItem) HeroEquipment.EquipmentSlots[Slots.SLOT_WEAPON];
			double damage = equippedWeapon.DamagePerSecond * (1 + ((double) TotalPrimaryAttributes.Dexterity / 100));

			return damage;
		}

	}
}
