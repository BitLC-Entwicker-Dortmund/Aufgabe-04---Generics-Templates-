using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flaschen
{
	class Beer : Drink
	{
		public string Brewery { get; private set; }

		public Beer(string name, string brewery)
			: base(name)
		{
			Brewery = brewery;
		}

		public string GetBrewery()
		{
			return Brewery;
		}

		public override string ToString()
		{
			return string.Format("Beer: Name={0}, Brewery={1}", Name, Brewery);
		}
	}
}
