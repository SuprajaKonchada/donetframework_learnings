using DesignPatternsDemo.Factory.Interfaces;

namespace DesignPatternsDemo.Factory.Classes
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
