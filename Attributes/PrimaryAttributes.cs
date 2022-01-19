namespace ConsoleRPG
{
	public struct PrimaryAttributes
	{
		// Attribute bonuses
		public int Strength;
		public int Dexterity;
		public int Intelligence;

		public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
		{
			return new PrimaryAttributes() { 
				Dexterity = lhs.Dexterity + rhs.Dexterity, 
				Intelligence = lhs.Intelligence + rhs.Intelligence, 
				Strength = lhs.Strength + rhs.Strength
			};
		}
	}
}