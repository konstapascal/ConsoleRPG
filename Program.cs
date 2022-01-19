using System;
using ConsoleRPG.Hero.HeroClasses;
using ConsoleRPG.Items;

namespace ConsoleRPG
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Console RPG by Konstantinos Pascal!\n");

			WarriorHero testWarrior = new WarriorHero("Guts");

			WeaponItem testAxe = new WeaponItem("Common Axe", 1, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes() { BaseDamage = 20, AttacksPerSecond = 1.5 });
			ArmorItem testArmor = new ArmorItem("Common Plate", 1, Slots.SLOT_BODY, ArmorType.ARMOR_PLATE, new PrimaryAttributes() { Strength = 10 });


			testWarrior.EquipItem(testAxe, Slots.SLOT_WEAPON);

			testWarrior.DisplayHeroStats();

			testWarrior.EquipItem(testArmor, Slots.SLOT_BODY);

			testWarrior.DisplayHeroStats();
			testWarrior.LevelUp();

			testWarrior.DisplayHeroStats();
			testWarrior.LevelUp();
		}
	}
}
