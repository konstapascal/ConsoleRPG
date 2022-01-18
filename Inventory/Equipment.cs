using ConsoleRPG.Items;
using System;
using System.Collections.Generic;

namespace ConsoleRPG.Inventory
{
	public class Equipment
	{
		private string[] SlotTypes { get; init; } = { "Head", "Body", "Legs", "Weapon" };
		public Dictionary<string, Item> EquipmentSlots { get; set; }

		public Equipment()
		{

			EquipmentSlots = new Dictionary<string, Item>();

			for (int i = 0; i < SlotTypes.Length; i++)
			{
				EquipmentSlots[SlotTypes[i]] = null;
			}
		}
		
		public int EquipItem(Item item)
		{
			throw new NotImplementedException();
		}

		public int RemoveItem(Item item)
		{
			throw new NotImplementedException();
		}
	}
}
