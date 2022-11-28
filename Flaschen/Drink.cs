using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flaschen
{
	internal class Drink
	{
		public string Name { get; private set; }

		public Drink(string name)
		{
			Name = name;
		}
	}
}
