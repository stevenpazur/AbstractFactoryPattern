using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
    public class SteakHouse : IMenu
    {
        List<string> Appetizers = new() {"Small Meat", "Small Meat Pt. 2"};
        List<string> Mains = new() {"T-Bone", "Big Meat", "Meat Salad"};
        List<string> Desserts = new() {"Cake", "Pecan Pie"};
        List<string> Drinks = new() {"Water", "Beer"};

        public void getMenu()
        {
            Console.WriteLine("Appetizers: " + String.Join(",", Appetizers));
            Console.WriteLine("Mains: " + String.Join(",", Mains));
            Console.WriteLine("Desserts: " + String.Join(",", Desserts));
            Console.WriteLine("Drinks: " + String.Join(",", Drinks));
        }
    }
}