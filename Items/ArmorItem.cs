using ConsoleRPG.Attributes;

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
