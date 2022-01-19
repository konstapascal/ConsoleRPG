using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Hero.HeroClasses
{
	public class MageHero : Hero
	{
		// Constructor
		public MageHero(string name) : base(name)
		{
			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 8 };
			BasePrimaryAttributesGain = new PrimaryAttributes() { Strength = 1, Dexterity = 1, Intelligence = 5 };

			TotalPrimaryAttributes = new PrimaryAttributes() { Strength = 1, Dexterity= 1, Intelligence = 8 };

			AllowedWeaponTypes = new List<string> { WeaponType.WEAPON_STAFF, WeaponType.WEAPON_WAND };
			AllowedArmorTypes = new List<string> { ArmorType.ARMOR_CLOTH };

		}

		// Methods
		public override int DealDamage()
		{
			throw new NotImplementedException();
		}

	}
}
