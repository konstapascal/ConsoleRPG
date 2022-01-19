using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Hero.HeroClasses
{
	public class RogueHero : Hero
	{
		// Constructor
		public RogueHero(string name) : base(name)
		{
			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 2, Dexterity = 6, Intelligence = 1 };
			BasePrimaryAttributesGain = new PrimaryAttributes() { Strength = 1, Dexterity = 4, Intelligence = 1 };

			BasePrimaryAttributes = new PrimaryAttributes() { Strength = 2, Dexterity = 6, Intelligence = 1 };

			AllowedWeaponTypes = new List<string> { WeaponType.WEAPON_DAGGER, WeaponType.WEAPON_SWORD };
			AllowedArmorTypes = new List<string> { ArmorType.ARMOR_MAIL, ArmorType.ARMOR_PLATE };

		}

		// Methods
		public override int DealDamage()
		{
			throw new NotImplementedException();
		}

	}
}
