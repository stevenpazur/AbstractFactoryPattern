using System;

namespace AbstractFactoryPattern {
    public class SteakHouseFactory : AbstractFactory
    {
        public override IMenu DrawMenu()
        {
            return new SteakHouse();
        }
    }
}