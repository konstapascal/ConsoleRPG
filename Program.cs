using ConsoleRPG.Attributes;
using ConsoleRPG.Hero.HeroClasses;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System;

namespace ConsoleRPG
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Console RPG by Konstantinos Pascal!\n");

			WarriorHero testWarrior = new WarriorHero("Guts");

			WeaponItem testAxe = new WeaponItem("Common Axe", 1, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes() { BaseDamage = 7, AttacksPerSecond = 1.1 });
			ArmorItem testArmor = new ArmorItem("Common Plate", 1, Slots.SLOT_BODY, ArmorType.ARMOR_PLATE, new PrimaryAttributes() { Strength = 1 });

			testWarrior.EquipItem(testAxe, Slots.SLOT_WEAPON);
			testWarrior.EquipItem(testArmor, Slots.SLOT_BODY);

			testWarrior.LevelUp();
			testWarrior.LevelUp();

			testWarrior.DisplayHeroStats();
		}
	}
}
