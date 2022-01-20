using System;

namespace ConsoleRPG.Exceptions.CustomExceptions
{
	public class InvalidWeaponException : Exception
	{
		public InvalidWeaponException() { }
		public InvalidWeaponException(string message) : base(message) { }
	}
}