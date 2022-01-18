using ConsoleRPG.Hero.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Inventory;

namespace ConsoleRPG.Hero
{
	public abstract class Hero
	{

		// Properties
		public string Name { get; set; }
		public int Level { get; set; } = 1;
		public abstract PrimaryAttributes BasePrimaryAttributes { get; set; }
		public abstract PrimaryAttributes BasePrimaryAttributesGain { get; set; }
		public abstract PrimaryAttributes TotalPrimaryAttributes { get; set; }
		public Equipment HeroEquipment { get; set; }
		public abstract string[] AllowedWeaponTypes { get; set; }
		public abstract string[] AllowedArmorTypes { get; set; }

		// Methods
		public abstract int LevelUp();
		public abstract int DealDamage();
		public abstract string DisplayHeroStats();
	}
}
