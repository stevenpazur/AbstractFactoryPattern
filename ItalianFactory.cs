using System;

namespace AbstractFactoryPattern {
    public class ItalianFactory : AbstractFactory
    {
        public override IMenu DrawMenu()
        {
            return new Italian();
        }
    }
}