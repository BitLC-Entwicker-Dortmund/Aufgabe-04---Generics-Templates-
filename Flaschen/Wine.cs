using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flaschen
{
	internal abstract class Wine : Drink
	{
		public string Origin { get; private set; }

		public Wine(string name, string origin)
			: base(name)
		{
			Origin = origin;
		}

		public string GetOrigin()
		{
			return Origin;
		}

		public override string ToString()
		{
			return string.Format("Name: {0}, Origin: {1}", Name, Origin);
		}
	}
}
