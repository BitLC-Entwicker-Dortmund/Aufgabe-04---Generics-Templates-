using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flaschen
{
	class Bottle<T> where T: Drink
	{
		public T Drink { get; private set; }

		public Bottle()
		{
			Drink = default;
		}

		public bool IsEmpty()
		{
			return Drink == null;
		}

		public void Fill(T drink)
		{
			Drink = drink;
		}

		public void Empty(out T drink)
		{
			drink = Drink;
			Drink = null;
		}
	}
}
