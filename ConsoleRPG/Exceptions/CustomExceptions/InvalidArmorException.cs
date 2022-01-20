using System;

namespace ConsoleRPG.Exceptions.CustomExceptions
{
	public class InvalidArmorException : Exception
	{
		public InvalidArmorException() { }
		public InvalidArmorException(string message) : base(message) { }
	}
}