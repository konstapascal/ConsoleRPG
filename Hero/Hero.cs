using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Hero
{
	public abstract class Hero
	{

		public string Name { get; set; }
		public int Level { get; set; }
		public Attribute BasePrimaryAttributes { get; set; }
		public Attribute TotalPrimaryAttributes { get; set; }

	}
}
