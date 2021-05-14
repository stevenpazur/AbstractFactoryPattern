using System;

namespace AbstractFactoryPattern {
    public class FrenchFactory : AbstractFactory
    {
        public override IMenu DrawMenu()
        {
            return new French();
        }
    }
}