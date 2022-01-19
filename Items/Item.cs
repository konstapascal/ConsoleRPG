using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Items
{
	public abstract class Item
	{
		// Constructor
		protected Item(string itemName, int itemLevel, string itemSlot, string itemType)
		{
			ItemName = itemName;
			ItemLevel = itemLevel;
			ItemSlot = itemSlot;
			ItemType = itemType;
		}

		// Properties
		public string ItemName { get; init; }
		public int ItemLevel { get; init; }
		public string ItemSlot { get; init; }
		public string ItemType { get; init; }
	}
}
