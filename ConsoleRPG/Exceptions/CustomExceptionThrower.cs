using ConsoleRPG.Exceptions.CustomExceptions;
using ConsoleRPG.Inventory;
using ConsoleRPG.Items;
using System.Collections.Generic;

namespace ConsoleRPG.Exceptions
{
	public static class CustomExceptionThrower
	{
		/// <summary>
		/// Throws a weapon exception if the item level is too high, is not allowed to be equipped or is equipped in the wrong slot
		/// </summary>
		/// <param name="item">Item to be checked</param>
		/// <param name="slot">Slot in which the item is to be equipped</param>
		/// <param name="isWeapon">Boolean value if the item a weapon</param>
		/// <param name="level">Current level of the character</param>
		/// <param name="allowedWeaponTypes">Allowed weapon types to be equipped by the character</param>
		/// <exception cref="InvalidWeaponException"></exception>
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

		/// <summary>
		/// Throws an armor exception if the item level is too high, is not allowed to be equipped or is equipped in the wrong slot
		/// </summary>
		/// <param name="item">Item to be checked</param>
		/// <param name="slot">Slot in which the item is to be equipped</param>
		/// <param name="isArmor">Boolean value if the item an armor</param>
		/// <param name="level">Current level of the character</param>
		/// <param name="allowedArmorTypes">Allowed armor types to be equipped by the character</param>
		/// <exception cref="InvalidArmorException"></exception>
		/// <exception cref="InvalidWeaponException"></exception>
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
