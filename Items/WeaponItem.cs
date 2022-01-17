using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Items
{
	public class WeaponItem : Item
	{
		public double BaseDamage { get; set; }
		public double AttacksPerSecond { get; set; }
		public double DamagePerSecond { get; set; }
	}
}
