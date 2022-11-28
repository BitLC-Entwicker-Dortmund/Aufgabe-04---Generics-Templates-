using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flaschen
{
	class Water : Drink
	{
		public Water(string name)
			: base(name)
		{
			
		}

		public override string ToString()
		{
			return string.Format("Water: Name={0}", Name);
		}
	}
}
