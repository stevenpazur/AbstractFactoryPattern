using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the jungle!  What do you want to eat? (fast food/steak house/french/italian");
            string input = Console.ReadLine();
            AbstractFactory shapeFactory = FactoryProducer.GetFactory(input);
            shapeFactory.DrawMenu().getMenu();
        }
    }
}
