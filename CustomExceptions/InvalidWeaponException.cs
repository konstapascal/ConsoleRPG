using System;
using System.Runtime.Serialization;

namespace ConsoleRPG
{
	[Serializable]
	internal class InvalidWeaponException : Exception
	{
		public InvalidWeaponException() { }
		public InvalidWeaponException(string message) : base(message) { }
	}
}