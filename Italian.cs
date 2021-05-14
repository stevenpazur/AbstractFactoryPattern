using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
    public class Italian : IMenu
    {
        List<string> Appetizers = new() {"Lasagna Fritter", "Crostine", "Antipasti Platter"};
        List<string> Mains = new() {"Spaghetti", "Lasagna", "Pizza", "Chicken Alfredo", "Ravioli", "Manicotti"};
        List<string> Desserts = new() {"Canole", "Lemon Tart"};
        List<string> Drinks = new() {"Agua", "Agua Al Dente", "Fancy Italian Wine"};

        public void getMenu()
        {
            Console.WriteLine("Appetizers: " + String.Join(",", Appetizers));
            Console.WriteLine("Mains: " + String.Join(",", Mains));
            Console.WriteLine("Desserts: " + String.Join(",", Desserts));
            Console.WriteLine("Drinks: " + String.Join(",", Drinks));
        }
    }
}