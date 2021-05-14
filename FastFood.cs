using System;
using System.Collections.Generic;

namespace AbstractFactoryPattern {
    public class FastFood : IMenu
    {
        List<string> Appetizers = new() {"Apple Pie", "Fries", "Salad", "Onion Rings", "Curly Fries"};
        List<string> Mains = new() {"Chikkie Nuggies", "Borger", "Chicken Sandie", "Spicy Tuna Leftover Casserole (Chef's Special)"};
        List<string> Desserts = new() {"Pure MSG", "Apple Pie with MSG", "Cookies", "Crispy Fried Cheese"};
        List<string> Drinks = new() {"Grease-i-cola", "Sewer Water", "Dentist Salt", "Pepsi Blind"};

        public void getMenu()
        {
            Console.WriteLine("Appetizers: " + String.Join(",", Appetizers));
            Console.WriteLine("Mains: " + String.Join(",", Mains));
            Console.WriteLine("Desserts: " + String.Join(",", Desserts));
            Console.WriteLine("Drinks: " + String.Join(",", Drinks));
        }
    }
}