using ConsoleRPG.Items;
using System;
using System.Collections.Generic;

namespace ConsoleRPG.Inventory
{
	public class Equipment
	{
		// Constructor
		public Equipment()
		{
			EquipmentSlots = new Dictionary<string, Item>();

			for (int i = 0; i < SlotTypes.Count; i++)
			{
				EquipmentSlots.Add(SlotTypes[i], null);
			}
		}
		
		// Properties
		public List<string> SlotTypes { get; init; } = new List<string>() { Slots.SLOT_HEAD, Slots.SLOT_BODY, Slots.SLOT_LEGS, Slots.SLOT_WEAPON };
		public Dictionary<string, Item> EquipmentSlots { get; set; }

	}
}
