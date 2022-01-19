using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Items
{
	public class ArmorItem : Item
	{
		// Constructor
		public ArmorItem(string itemName, int itemLevel, string itemSlot, string armorType, PrimaryAttributes attributes) : base(itemName, itemLevel, itemSlot, armorType)
		{
			Attributes = attributes;
		}

		// Properties
		public PrimaryAttributes Attributes { get; init; }
	}
}
