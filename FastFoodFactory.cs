using System;

namespace AbstractFactoryPattern {
    public class FastFoodFactory : AbstractFactory
    {
        public override IMenu DrawMenu()
        {
            return new FastFood();
        }
    }
}