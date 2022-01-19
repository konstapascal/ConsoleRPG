using System;
using System.Runtime.Serialization;

namespace ConsoleRPG
{
	[Serializable]
	internal class InvalidArmorException : Exception
	{
		public InvalidArmorException() { }
		public InvalidArmorException(string message) : base(message) { }
	}
}