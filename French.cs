using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
    public class French : IMenu
    {
        List<string> Appetizers = new() {"Escargots a la Bourguignonne", "Provencal Stuffed Squid", "Duck Pate en Croute", "Pissaladiere"};
        List<string> Mains = new() {"Chicken Basquaise", "Barigoule of Spring Vegetables", "Alsatian Bacon and onion tart", "Cherry Gateau Basque", "Steak Diane"};
        List<string> Desserts = new() {"Tulipes", "Crepes", "Palmiers", "Calisson"};
        List<string> Drinks = new() {"Kirsch", "Ti-punch", "Pastis", "Pican Biere"};

        public void getMenu()
        {
            Console.WriteLine("Appetizers: " + String.Join(",", Appetizers));
            Console.WriteLine("Mains: " + String.Join(",", Mains));
            Console.WriteLine("Desserts: " + String.Join(",", Desserts));
            Console.WriteLine("Drinks: " + String.Join(",", Drinks));
        }
    }
}