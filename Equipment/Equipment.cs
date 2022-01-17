using ConsoleRPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Equipment
{
	public class Equipment
	{
		public Dictionary<string, Item> EquipmentSlots { get; set; }
		public string[] SlotTypes { get; init; } = { "Head", "Body", "Legs", "Weapon" };

		public Equipment()
		{

			EquipmentSlots = new Dictionary<string, Item>();

			for (int i = 0; i < SlotTypes.Length; i++)
			{
				EquipmentSlots[SlotTypes[i]] = null;
			}
		}
		
		public int AddItem(Item item)
		{
			throw new NotImplementedException();
		}

		public int RemoveItem(Item item)
		{
			throw new NotImplementedException();
		}
	}
}
