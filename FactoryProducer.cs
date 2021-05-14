using System;

namespace AbstractFactoryPattern {
    public class FactoryProducer {
        public static AbstractFactory GetFactory(string factory) {
            switch (factory) {
                case "fast food": 
                    return new FastFoodFactory();
                case "french":
                    return new FrenchFactory();
                case "italian":
                    return new ItalianFactory();
                case "steak house":
                    return new SteakHouseFactory();
                default:
                    return new SteakHouseFactory();
            }
        }
    }
}