﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Items
{
	public abstract class Item
	{
		public string ItemName { get; set; }
		public int ItemLevel { get; set; }
		public string ItemSlot { get; set; }
	}
}