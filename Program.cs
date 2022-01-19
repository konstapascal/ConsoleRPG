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

			testWarrior.LevelUp();

			WeaponItem testAxe = new WeaponItem("Common Axe", 2, Slots.SLOT_WEAPON, WeaponType.WEAPON_AXE, new WeaponAttributes() { BaseDamage = 7, AttacksPerSecond = 1.1 });

			testWarrior.EquipItem(testAxe, Slots.SLOT_WEAPON);

			Console.WriteLine(testAxe.DamagePerSecond);
		}
	}
}
