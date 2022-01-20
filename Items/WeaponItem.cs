using ConsoleRPG.Attributes;

namespace ConsoleRPG.Items
{
	public class WeaponItem : Item
	{
		// Constructor
		public WeaponItem(string itemName, int itemLevel, string itemSlot, string weaponType, WeaponAttributes attributes) : base(itemName, itemLevel, itemSlot, weaponType)
		{
			Attributes = attributes;
			DamagePerSecond = Attributes.BaseDamage * Attributes.AttacksPerSecond;
		}

		// Properties
		public WeaponAttributes Attributes { get; init; }
		public double DamagePerSecond { get; init; }
	}
}
