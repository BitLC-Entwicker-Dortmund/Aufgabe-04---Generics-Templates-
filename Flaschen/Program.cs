using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen
{
	class Program
	{
		static void Main(string[] args)
		{
			Water water = new Water("Wasser");
			Console.WriteLine(water);
			
			Beer beer = new Beer("Bier", "Augustiner");
			string name = beer.GetBrewery();
			Console.WriteLine(beer);

			Wine redwine = new RedWine("Rotwein", "South Africa");
			string origin_red = redwine.GetOrigin();
			Console.WriteLine(redwine);
			
			Wine whitewhine = new WhiteWhine("Weißwein", "France");
			string origin_white = whitewhine.GetOrigin();
			Console.WriteLine(whitewhine);


			Console.WriteLine("".PadRight(80, '='));
			// =====================================================
			// ==========         WATER 
			// =====================================================

			Bottle<Water> water_bottle = new Bottle<Water>();
			Console.WriteLine("The bottle is {0}.", water_bottle.IsEmpty() ? "empty" : "filled");
			
			water_bottle.Fill(water);
			Console.WriteLine("Filled the bottle with \"{0}\"...", water_bottle.Drink.Name);
			Console.WriteLine("The bottle is {0}.", water_bottle.IsEmpty() ? "empty" : "filled");
			
			water = null;
			water_bottle.Empty(out water);
			Console.WriteLine("Emptying the bottle of \"{0}\"...", water.Name);
			Console.WriteLine("The bottle is {0}.", water_bottle.IsEmpty() ? "empty" : "filled");
			

			Console.WriteLine("".PadRight(80, '='));
			// =====================================================
			// ==========         Red Wine 
			// =====================================================

			Bottle<Wine> wine_bottle0 = new Bottle<Wine>();
			Console.WriteLine("The bottle is {0}.", wine_bottle0.IsEmpty() ? "empty" : "filled");
			
			wine_bottle0.Fill(redwine);
			Console.WriteLine("Filled the bottle with \"{0}\"...", wine_bottle0.Drink.Name);
			Console.WriteLine("The Wine's origin is: {0}", wine_bottle0.Drink.Origin);
			Console.WriteLine("The bottle is {0}.", wine_bottle0.IsEmpty() ? "empty" : "filled");

			redwine = null;
			wine_bottle0.Empty(out redwine);
			Console.WriteLine("Emptying the bottle of \"{0}\"...", redwine.Name);
			Console.WriteLine("The bottle is {0}.", wine_bottle0.IsEmpty() ? "empty" : "filled");
			

			Console.WriteLine("".PadRight(80, '='));
			// =====================================================
			// ==========         White Wine 
			// =====================================================

			Bottle<Wine> wine_bottle1 = new Bottle<Wine>();
			Console.WriteLine("The bottle is {0}.", wine_bottle1.IsEmpty() ? "empty" : "filled");
			
			wine_bottle1.Fill(whitewhine);
			Console.WriteLine("Filled the bottle with \"{0}\"...", wine_bottle1.Drink.Name);
			Console.WriteLine("The Wine's origin is: {0}", wine_bottle1.Drink.Origin);
			Console.WriteLine("The bottle is {0}.", wine_bottle1.IsEmpty() ? "empty" : "filled");

			whitewhine = null;
			wine_bottle1.Empty(out whitewhine);
			Console.WriteLine("Emptying the bottle of \"{0}\"...", whitewhine.Name);
			Console.WriteLine("The bottle is {0}.", wine_bottle1.IsEmpty() ? "empty" : "filled");
			

			Console.WriteLine("".PadRight(80, '='));
			// =====================================================
			// ==========         Beer 
			// =====================================================

			Bottle<Beer> beer_bottle = new Bottle<Beer>();
			Console.WriteLine("The bottle is {0}.", beer_bottle.IsEmpty() ? "empty" : "filled");
			
			beer_bottle.Fill(beer);
			Console.WriteLine("Filled the bottle with \"{0}\"...", beer_bottle.Drink.Name);
			Console.WriteLine("The Beer's brewery is: {0}", beer_bottle.Drink.Brewery);
			Console.WriteLine("The bottle is {0}.", beer_bottle.IsEmpty() ? "empty" : "filled");

			beer = null;
			beer_bottle.Empty(out beer);
			Console.WriteLine("Emptying the bottle of \"{0}\"...", beer.Name);
			Console.WriteLine("The bottle is {0}.", beer_bottle.IsEmpty() ? "empty" : "filled");
			
			Console.WriteLine("".PadRight(80, '='));


			Bottle<Beer> beerBottle =  new Bottle<Beer>();
			//Bottle<Drink> drinkBottle = (Bottle<Drink>)beerBottle;
			Console.Read ( );
		}
	}
}
