using DesignPatternsDemo.Factory.Interfaces;

namespace DesignPatternsDemo.Factory.Classes
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
