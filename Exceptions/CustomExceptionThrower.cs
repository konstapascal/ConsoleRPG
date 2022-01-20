using ConsoleRPG.Exceptions.CustomExceptions;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System.Collections.Generic;

namespace ConsoleRPG.Exceptions
{
	public static class CustomExceptionThrower
	{
		public static void WeaponExceptionThrower(Item item, string slot, bool isWeapon, int level, List<string> allowedWeaponTypes)
		{
			// Throws error if weapons item level is too high
			if (isWeapon && item.ItemLevel > level)
				throw new InvalidWeaponException("Weapon level too high!");
			// Throws error if weapons type is not allowed to be equipped
			if (isWeapon && !allowedWeaponTypes.Contains(item.ItemType))
				throw new InvalidWeaponException("Weapon type not allowed to be equipped!");
			// Throws error if weapon is equipped in an armor slot
			if (isWeapon && slot != Slots.SLOT_WEAPON)
				throw new InvalidWeaponException("Cannot equip weapon in an armor slot!");
		}

		public static void ArmorExceptionThrower(Item item, string slot, bool isArmor, int level, List<string> allowedArmorTypes)
		{
			// Throws error if armors item level is too high
			if (isArmor && item.ItemLevel > level)
				throw new InvalidArmorException("Armor level too high!");
			// Throws error if armors type is not allowed to be equipped
			if (isArmor && !allowedArmorTypes.Contains(item.ItemType))
				throw new InvalidArmorException("Armor type not allowed to be equipped!");
			// Throws error if armor is equipped in a weapon slot
			if (isArmor && slot == Slots.SLOT_WEAPON)
				throw new InvalidWeaponException("Cannot equip armor in a weapon slot!");
		}
	}
}
