using DesignPatternsDemo.Factory.Interfaces;

namespace DesignPatternsDemo.Factory.Classes
{
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
